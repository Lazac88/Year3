﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureBuilder
{
    public class Feet
    {
        protected string name;
        protected Bitmap image;
        public Bitmap Image
        {
            get { return image; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
