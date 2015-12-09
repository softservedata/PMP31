using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ElectronicsShop.Models
{
    public class UserModel
    {
        public int id_user { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string email { get; set; }

        public string phone_number { get; set; }

        [Required(ErrorMessage = "Please, input your login")]
        public string login { get; set; }

        [Required(ErrorMessage = "Please, input your password")]
        public string password { get; set; }

        public int id_role { get; set; }
    }
}