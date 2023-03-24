using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ServiceValidator:AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(s => s.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(s => s.Title).MinimumLength(3).WithMessage("Başlık alanı 3 karakterden fazla olmalıdır");
            RuleFor(s => s.Title).MaximumLength(60).WithMessage("Başlık alanı 60 karakterden az olmalıdır");
            RuleFor(s => s.ImageUrl).NotEmpty().WithMessage("Hizmet resim alanı boş geçilemez");
        }
    }
}
