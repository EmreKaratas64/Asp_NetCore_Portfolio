using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Areas.Writer.Models
{
    public class AddRefrence
    {
        [Required(ErrorMessage = "Lütfen isminizi girin")]
        [MinLength(5,ErrorMessage ="Ad ve soyadınız 5 karakterden fazla olmalıdır!")]
        [MaxLength(100,ErrorMessage ="Ad ve soyadınız 100 karakterden fazla olmamalıdır!")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Lütfen şirket bilginizi giriniz!")]
        public string company { get; set; }

        [Required(ErrorMessage = "Lütfen bir yorum girin")]
        [MinLength(10,ErrorMessage = "Yorum uzunluğu 10 karakterden fazla olmalıdır!")]
        public string comment { get; set; }

        [Required(ErrorMessage ="Lütfen bir resim seçiniz!")]
        public IFormFile Image { get; set; }

    }
}
