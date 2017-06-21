using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarEvents
{
    public class TrackBarObserver : ProgressBaseObserver
    {
        private TrackBar trackBar1;

        public TrackBarObserver(ProgressBarSubject subject, TrackBar tb) 
            : base(subject)
        {
            trackBar1 = tb;
        }

        public override void ProgressBarHandlerMethod(object progressSubject, EventArgs e)
        {
            trackBar1.Value++;
        }

        public override void ClearHandlerMethod(object progressSubject, EventArgs e)
        {
            trackBar1.Value = 0;
        }
    }
}
