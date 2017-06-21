using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    public class GCard
    {
        protected string name;
        public string Name
        {
            get { return name; }
        }
        protected double price;
        public double Price
        {
            get { return price; }
        }

        public override string ToString()
        {
            string myPrice = Convert.ToString(price);
            string returnString = myPrice + "     " + name;
            return returnString;
        }
    }
}
