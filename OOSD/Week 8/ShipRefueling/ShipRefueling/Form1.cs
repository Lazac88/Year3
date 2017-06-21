using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipRefueling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public const int SHIP_SIZE = 60;

        private Random rand;
        private GraphicDisplay graphicDisplay;
        private List<Ship> shipList;
        private List<PetrolBot> botList;
        private Point moveableArea;

        private void Form1_Load(object sender, EventArgs e)
        {
            graphicDisplay = new GraphicDisplay(displayPanel, new Point(displayPanel.Width, displayPanel.Height));                        
            moveableArea = new Point(displayPanel.Width, (displayPanel.Height - SHIP_SIZE));
            rand = new Random();

            shipList = new List<Ship>();
            botList = new List<PetrolBot>();
            CreateShipsAndBots();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graphicDisplay.clearPanel();
            graphicDisplay.drawBase();
            foreach(Ship s in shipList)
            {
                s.Run();
            }
            foreach(PetrolBot p in botList)
            {
                p.Run();
            }
            graphicDisplay.drawToCanvas();
        }

        private void CreateShipsAndBots()
        {
            Ship ship1 = new Ship(new Point(80, 80), new Point(1, 1), graphicDisplay, moveableArea, rand);
            Ship ship2 = new Ship(new Point(160, 160), new Point(-1, 0), graphicDisplay, moveableArea, rand);
            Ship ship3 = new Ship(new Point(240, 240), new Point(0, -1), graphicDisplay, moveableArea, rand);
            Ship ship4 = new Ship(new Point(320, 320), new Point(1, 0), graphicDisplay, moveableArea, rand);
            Ship ship5 = new Ship(new Point(400, 400), new Point(0, 1), graphicDisplay, moveableArea, rand);

            shipList.Add(ship1);
            shipList.Add(ship2);
            shipList.Add(ship3);
            shipList.Add(ship4);
            shipList.Add(ship5);

            PetrolBot p1 = new PetrolBot(new Point(20, 760), Color.Green, graphicDisplay, ship1);
            PetrolBot p2 = new PetrolBot(new Point(50, 760), Color.Red, graphicDisplay, ship2);
            PetrolBot p3 = new PetrolBot(new Point(80, 760), Color.Orange, graphicDisplay, ship3);
            PetrolBot p4 = new PetrolBot(new Point(110, 760), Color.Yellow, graphicDisplay, ship4);
            PetrolBot p5 = new PetrolBot(new Point(140, 760), Color.Pink, graphicDisplay, ship5);

            botList.Add(p1);
            botList.Add(p2);
            botList.Add(p3);
            botList.Add(p4);
            botList.Add(p5);
        }
    }
}
