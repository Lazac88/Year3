using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarmEvents
{
    public class FireAlarmEventArgs : EventArgs
    {
        public EFireCategory FireCategory { get; set; }

        public FireAlarmEventArgs(EFireCategory currentFireCategory)
        {
            FireCategory = currentFireCategory;
        }
    }
}
