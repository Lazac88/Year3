using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureBuilder
{
    public class SkeletonHead : Head
    {
        public SkeletonHead()
        {
            name = "Skeleton Head";
            image = new Bitmap("Skeleton_0.png");
        }
    }
}
