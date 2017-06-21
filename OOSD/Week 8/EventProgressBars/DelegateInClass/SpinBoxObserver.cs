using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarEvents
{
    public class SpinBoxObserver : ProgressBaseObserver
    {
        NumericUpDown numericUpDown1;

        public SpinBoxObserver(ProgressBarSubject subject, NumericUpDown nu)
            : base(subject)
        {
            this.numericUpDown1 = nu;
        }

        public override void ProgressBarHandlerMethod(object progressSubject, EventArgs e)
        {
            numericUpDown1.Value++;
            Application.DoEvents();
        }

        public override void ClearHandlerMethod(object progressSubject, EventArgs e)
        {
            numericUpDown1.Value = 0;
        }
    }
}
