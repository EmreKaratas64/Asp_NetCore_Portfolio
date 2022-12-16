using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Areas.Writer.Models
{
    public class UserForgetPasswordViewModel
    {
        [Required(ErrorMessage = "Lütfen isminizi girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyisminizi girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresinizi girin")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen bir şifre girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi onaylayın")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }

    }
}
