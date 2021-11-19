using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.webui.Models
{
    public class RegisterModel
    {
        [Required]
        [Display(Prompt = "Ad...")]
        public string FirstName { get; set; }

        [Required]
        [Display(Prompt = "Soyad...")]
        public string LastName { get; set; }

        [Required]
        [Display(Prompt = "Kullanıcı Adı...")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Prompt = "Şifre...")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")] //yukarıdaki girdiğimiz password değeriyle aynı olmak zorunda...
        [Display(Prompt = "Şifre tekrar...")]
        public string RePassword { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Prompt = "E-mail...")]
        public string Email { get; set; }

    }
}
