using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureBuilder
{
    public class SkeletonBody : Body
    {
        public SkeletonBody()
        {
            name = "Skeleton Body";
            image = new Bitmap("Skeleton_1.png");
        }
    }
}
