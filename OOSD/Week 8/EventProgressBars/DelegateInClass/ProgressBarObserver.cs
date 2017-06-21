using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarEvents
{
    public class ProgressBarObserver : ProgressBaseObserver
    {

        ProgressBar progressBar1;

        public ProgressBarObserver(ProgressBarSubject subject, ProgressBar pb)
            : base(subject)
        {
            this.progressBar1 = pb;
        }

        public override void ProgressBarHandlerMethod(object progressSubject, EventArgs e)
        {
            progressBar1.Increment(1);
        }

        public override void ClearHandlerMethod(object progressSubject, EventArgs e)
        {
            progressBar1.Value = 0;
        }
    }
}
