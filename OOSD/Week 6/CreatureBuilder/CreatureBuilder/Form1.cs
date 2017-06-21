using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatureBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics canvas;
        CreatureFactoryFactory cff;

        //An array of creatures which makes it easy to add another creature to the combo boxes
        string[] myCreatures = new string[] { "Monster", "Skeleton", "Witch" };

        //Creatrue Factories
        ICreature selectedHead;
        ICreature selectedBody;
        ICreature selectedFeet;

        //Body Parts
        Head head;
        Body body;
        Feet feet;

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = CreateGraphics();
            cff = new CreatureFactoryFactory();
            //Add items to combo boxes
            foreach(string c in myCreatures)
            {
                populateCombo(c);
            }
            comboHead.SelectedIndex = 0;
            comboBody.SelectedIndex = 0;
            comboFeet.SelectedIndex = 0;
        }

        private void populateCombo(string monsterType)
        {
            comboHead.Items.Add(monsterType + " Head");
            comboBody.Items.Add(monsterType + " Body");
            comboFeet.Items.Add(monsterType + " Feet");
        }

        private void btnCreateCreature_Click(object sender, EventArgs e)
        {
            //Get correct factories
            setFactories();
            //Get body parts
            getBodyParts();
            //Draw images
            drawImages();
        }

        private void setFactories()
        {
            string head = comboHead.Text;
            switch(head)
            {
                case "Monster Head":
                    selectedHead = cff.getMonsterFactory();
                    break;
                case "Skeleton Head":
                    selectedHead = cff.getSkeletonFactory();
                    break;
                case "Witch Head":
                    selectedHead = cff.getWitchFactory();
                    break;
            }

            string body = comboBody.Text;
            switch (body)
            {
                case "Monster Body":
                    selectedBody = cff.getMonsterFactory();
                    break;
                case "Skeleton Body":
                    selectedBody = cff.getSkeletonFactory();
                    break;
                case "Witch Body":
                    selectedBody = cff.getWitchFactory();
                    break;
            }

            string feet = comboFeet.Text;
            switch (feet)
            {
                case "Monster Feet":
                    selectedFeet = cff.getMonsterFactory();
                    break;
                case "Skeleton Feet":
                    selectedFeet = cff.getSkeletonFactory();
                    break;
                case "Witch Feet":
                    selectedFeet = cff.getWitchFactory();
                    break;
            }
        }//End setFactories

        private void getBodyParts()
        {
            head = selectedHead.getHead();
            body = selectedBody.getBody();
            feet = selectedFeet.getFeet();
        }

        private void drawImages()
        {
            Bitmap headImage = head.Image;
            Bitmap bodyImage = body.Image;
            Bitmap feetImage = feet.Image;

            canvas.DrawImage(head.Image, 20, 20);
            canvas.DrawImage(body.Image, 20, 283);
            canvas.DrawImage(feet.Image, 20, 498);
        }
    }    
}
