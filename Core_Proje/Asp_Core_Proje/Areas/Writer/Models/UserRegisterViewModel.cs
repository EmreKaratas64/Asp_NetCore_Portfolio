using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen bir kullanıcı adı girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen bir isim girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen bir soyisim girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen reim url değeri girin")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage ="Lütfen bir şifre girin")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Lütfen şifrenizi onaylayın")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Lütfen bir şifre girin")]
        public string Mail { get; set; }

    }
}
