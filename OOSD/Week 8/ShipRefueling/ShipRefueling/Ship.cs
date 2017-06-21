using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipRefueling
{    
    public class Ship
    {
        private const int MAX_COLOUR_NUMBER = 255;
        private const int MAX_FUEL = 100;
        public const int SHIP_SIZE = 60;

        public delegate void RefuelEventHandler(object ship, PetrolEventArgs pe);

        public event RefuelEventHandler RefuelEvent;
        public event EventHandler FullEvent;

        private Point ShipLoc;
        private Point Velocity;
        private Point MoveableArea;
        private int Fuel;
        private EState ShipState;

        Random rand;
        
        private GraphicDisplay graphicDisplay;
        private Color currentColour;


        public Ship(Point startLoc, Point startVel, GraphicDisplay graphicDisplay, Point moveableArea, Random rand)
        {
            this.ShipLoc = startLoc;
            this.Velocity = startVel;
            this.graphicDisplay = graphicDisplay;
            this.MoveableArea = moveableArea;
            Fuel = MAX_FUEL;
            ShipState = EState.MOVING;
            currentColour = Color.White;

            this.rand = rand;
        }

        public void UpdateState()
        {
            //Check if out of fuel. No need for a shipState check here
            if(Fuel <= 0)
            {
                ShipState = EState.FUELING;
                OnRefuelEvent(ShipLoc);
            }

            //If ship is fueling, check to see if fuel levels have reached MAX_FUEL
            if (ShipState == EState.FUELING)
            {
                if(Fuel >= MAX_FUEL)
                {
                    ShipState = EState.MOVING;
                    Velocity = GetRandomVelocity();
                    OnFullEvent();
                }
            }
        }

        public void Run()
        {
            if(ShipState == EState.FUELING)
            {
                UpdateState();
                IncreaseFuel();
                currentColour = UpdateColour();
                Draw();
            }
            if(ShipState == EState.MOVING)
            {
                UpdateState();
                DecreaseFuel();
                CheckCollision();
                Move();
                currentColour = UpdateColour();
                Draw();
            }
        }

        public Color UpdateColour()
        {
            double fuelPct = (Fuel / 100.00);
            double redD = fuelPct * MAX_COLOUR_NUMBER;
            int red = Convert.ToInt16(redD);

            //Some Checking to stop red value going out of bounds
            if(red < 0)
            {
                red = 0;
            }
            else if(red > MAX_COLOUR_NUMBER)
            {
                red = 255;
            }
            Color newColour = Color.FromArgb(red, 0, 0);
            return newColour;
        }

        public Point GetRandomVelocity()
        {
            Point newVel = new Point(0,0);
            while(newVel.X == 0 && newVel.Y ==0)
            {
                newVel.X = rand.Next(-1, 2);
                newVel.Y = rand.Next(-1, 2);
            }
            return newVel;

        }

        public void CheckCollision()
        {
            int nextStepX = ShipLoc.X += Velocity.X;
            int nextStepY = ShipLoc.Y += Velocity.Y;

            if(nextStepX < 0)
            {
                Velocity.X = 1;
            }
            if(nextStepY < 0)
            {
                Velocity.Y = 1;
            }

            int maxXValue = MoveableArea.X - SHIP_SIZE;
            int maxYValue = MoveableArea.Y - SHIP_SIZE;

            if(nextStepX > maxXValue)
            {
                Velocity.X = -1;
            }
            if(nextStepY > maxYValue)
            {
                Velocity.Y = -1;
            }
        }

        public void Move()
        {
            ShipLoc.X += Velocity.X;
            ShipLoc.Y += Velocity.Y;
        }

        public void Draw()
        {
            graphicDisplay.drawShip(ShipLoc, SHIP_SIZE, currentColour);
        }
            
        public void IncreaseFuel()
        {
            Fuel++;
        }

        public void DecreaseFuel()
        {
            Fuel--;
        }

        public void OnRefuelEvent(Point shipLoc)
        {
            PetrolEventArgs pe = new PetrolEventArgs(shipLoc);

            if(RefuelEvent != null)
            {
                RefuelEvent(this, pe);
            }
        }

        public void OnFullEvent()
        {
            EventArgs e = new EventArgs();

            if(FullEvent != null)
            {
                FullEvent(this, e);
            }
        }
    }
}
