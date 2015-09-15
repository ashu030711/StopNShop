using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StopNShop_1.Models
{
    public class UserLogin
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(15,MinimumLength=6,ErrorMessage="Minimum 6 Maximum 15 character allowed")]
        public string Password { get; set; }
    }
}