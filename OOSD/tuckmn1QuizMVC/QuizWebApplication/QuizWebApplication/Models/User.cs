using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizWebApplication.Models
{
    public class User
    {
        [Required]
        [Display(Name = "User name")]
        public String Name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String Password { get; set; }

        [Display(Name = "Remember on this computer")]
        public bool RememberMe { get; set; }
        

        public User()
        {
            //Required
        }

        public User(string Name, string Password)
        {
            this.Name = Name;
            this.Password = Password;
        }        
    }
}