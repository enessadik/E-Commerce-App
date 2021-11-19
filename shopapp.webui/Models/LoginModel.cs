using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.webui.Models
{
    public class LoginModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        // public string UserName { get; set; }

        [Display(Prompt = "E-mail...")]
        public string Email { get; set; }
        [Required]
        [Display(Prompt = "Şifre...")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
