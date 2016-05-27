using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Ledger.Models
{
    public class User : IdentityUser
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter a user name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a password.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        public string Password { get; set; }
        public string[] Prefs { get; set; }
    }
}
