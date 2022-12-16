using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Areas.Writer.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage ="Lütfen isminizi girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyisminizi girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi girin girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi onaylayın")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil")]
        public string PasswordConfirm { get; set; }

        public string PictureUrl { get; set; }

        public IFormFile Picture { get; set; }
    }
}
