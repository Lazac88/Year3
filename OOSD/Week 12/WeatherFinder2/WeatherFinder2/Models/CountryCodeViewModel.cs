using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeatherFinder2.Models
{    
    public class CountryCodeViewModel
    {
        public List<SelectListItem> CountryCodes { get; set; }
        public string SelectedCode { get; set; }
    }
}