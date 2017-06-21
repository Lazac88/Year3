using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metronome
{
    public class MetronomeObserver
    {
        protected Metronome metronome;

        public MetronomeObserver(Metronome metronome)
        {
            this.metronome = metronome;
            metronome.metronomeEvent += new Metronome.metronomeEventHandler(onMetronomeEvent);
        }

        public virtual void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            MessageBox.Show("Tick tock");
        }
    }

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Beeper : MetronomeObserver
    {
        private String soundFileName;

        //Sound player created on this thread so does not need to be invoked
        private SoundPlayer soundPlayer;

        public Beeper(Metronome metronome, String soundFileName)
            : base(metronome)
        {
            this.soundFileName = soundFileName;
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = soundFileName;
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            soundPlayer.Play();
        }

    } // end Beeper
    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Counter : MetronomeObserver
    {
        private NumericUpDown spinBox;

        //Create a delegate
        private delegate void incrementSpinBox();

        public Counter(Metronome metronome, NumericUpDown spinBox)
            : base(metronome)
        {
            this.spinBox = spinBox;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            if(spinBox.InvokeRequired)          //If spinbox is on a different thread
            {
                incrementSpinBox inb = new incrementSpinBox(incrementSpinner);
                spinBox.Invoke(inb);
            }
            else //SpinBox is on this thread
            {
                spinBox.Value++;
            }
        }

        public void incrementSpinner()
        {
            spinBox.Value++;
        }
    } // end Counter

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TimeDisplay : MetronomeObserver
    {
        private ListBox listBox;

        //Create a delegate
        private delegate void updateListBox(DateTime dateTime);

        public TimeDisplay(Metronome metronome, ListBox listBox)
            : base(metronome)
        {
            this.listBox = listBox;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            if (listBox.InvokeRequired) //If listBox is on a different thread
            {
                updateListBox ulb = new updateListBox(addTime);
                listBox.Invoke(ulb, e.currentTime);         //How to invoke and pass in a method parameter
            }
            else
            {
                DateTime currDateTime = e.currentTime;
                listBox.Items.Add(currDateTime.ToString());
            }            
        }

        public void addTime(DateTime dateTime)
        {
            listBox.Items.Add(dateTime.ToString());
        }
    } // end TimeDisplay
}
