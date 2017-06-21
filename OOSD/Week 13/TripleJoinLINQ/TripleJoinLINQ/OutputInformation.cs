using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJoinLINQ
{
    public class OutputInformation
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }

        public OutputInformation(string city, string country, string language)
        {
            this.City = city;
            this.Country = country;
            this.Language = language;
        }

        public override string ToString()
        {
            return City + ", " + Country + ", " + Language;
        }
    }
}
