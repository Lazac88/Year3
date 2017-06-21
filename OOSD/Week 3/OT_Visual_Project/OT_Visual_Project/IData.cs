using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT_Visual_Project
{
    interface IData
    {
        void addData(Point stimPoint, Boolean stimulus, Boolean click);
        void clearData();
        List<Stimulus> returnAllData();
    }
}
