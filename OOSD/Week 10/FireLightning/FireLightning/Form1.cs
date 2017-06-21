using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireLightning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BirdWatchersDbDataContext db;

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new BirdWatchersDbDataContext();

            DisplayAvgStrikeIntensity();
            DisplayThreeLargestFires();
            DisplayLatLongFileName();
            DisplayFireStrikes();
        }

        private void DisplayAvgStrikeIntensity()
        {
            var allStrikes = from b in db.tblStrikes
                             select b.strikeIntensity;

            double avgStrikeIntensity = allStrikes.Average();
            txtBoxStrikeIntensity.Text = avgStrikeIntensity.ToString();
        }

        private void DisplayThreeLargestFires()
        {
            var fires = (from f in db.tblFires
                        orderby f.fireArea descending
                        select f).Take(3);

            foreach(var f in fires)
            {
                String fireDisplay = "";
                fireDisplay += f.fireDate + "\t";
                fireDisplay += f.fireArea + "\t";

                lBoxLargeFires.Items.Add(fireDisplay);
            }
        }

        private void DisplayLatLongFileName()
        {
            var latLongFileName =  from latLong in db.tblFires
                                   join pic in db.tblPictures
                                   on latLong.fireID equals pic.pictureID
                                   select new { latLong.fireLatitude, latLong.fireLongitude, pic.pictureFileName };

            foreach(var x in latLongFileName)
            {
                String llf = x.fireLatitude.ToString() + "\t" + x.fireLongitude.ToString() + "\t" + x.pictureFileName;
                lBoxlatLongFile.Items.Add(llf);
            }
        }

        private void DisplayFireStrikes()
        {
            var fireStrikes = from fireTbl in db.tblFires
                              from strikeTbl in db.tblStrikes
                              where (strikeTbl.strikeLatitude == fireTbl.fireLatitude) && (strikeTbl.strikeLongitude == fireTbl.fireLongitude) && (strikeTbl.strikeDate == fireTbl.fireDate)
                              select fireTbl;

            foreach(var f in fireStrikes)
            {
                String details = f.fireDate.ToString() + "\t" + f.fireLatitude.ToString() + "\t" + f.fireLongitude.ToString();
                lBoxFireStrikes.Items.Add(details);
            }
        }
    }
}
