using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    public class CPU
    {
        protected string name;
        public string Name
        {
            get { return name; }
        }
        protected string clockrate;
        public string Clockrate
        {
            get { return clockrate; }
        }
        protected double price;
        public double Price
        {
            get { return price; }
        }

        public override string ToString()
        {
            string myPrice = Convert.ToString(price);
            string returnString = myPrice + "     " + name + ", " + clockrate;
            return returnString;
        }
    }
}
