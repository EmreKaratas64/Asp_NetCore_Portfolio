using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(f => f.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(f => f.Title).MinimumLength(3).WithMessage("Başlık alanı 3 karakterden fazla olmalıdır");
            RuleFor(f => f.Title).MaximumLength(50).WithMessage("Başlık alanı 50 karakterden az olmalıdır");
            RuleFor(f => f.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(f => f.Description).MinimumLength(4).WithMessage("Açıklama alanı 4 karakterden fazla olmalıdır");
            RuleFor(f => f.Age).NotEmpty().WithMessage("Yaş alanı boş geçilemez");

            RuleFor(f => f.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(f => f.Mail).MinimumLength(5).WithMessage("Mail alanı 5 karakterden fazla olmalıdır");
            RuleFor(f => f.Mail).MaximumLength(60).WithMessage("Mail alanı 60 karakterden az olmalıdır");

            RuleFor(f => f.Phone).NotEmpty().WithMessage("Telefon numarası alanı boş geçilemez");

            RuleFor(f => f.Address).NotEmpty().WithMessage("Adres alanı boş geçilemez");

            RuleFor(f => f.ImageUrl).NotEmpty().WithMessage("Fotoğraf alanı boş geçilemez");
        }
    }
}
