using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class FeatureValidator:AbstractValidator<Feature>
    {
        public FeatureValidator()
        {
            RuleFor(f => f.Header).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(f => f.Header).MinimumLength(3).WithMessage("Başlık alanı 3 karakterden fazla olmalıdır");
            RuleFor(f => f.Header).MaximumLength(50).WithMessage("Başlık alanı 50 karakterden az olmalıdır");
            RuleFor(f => f.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(f => f.Name).MinimumLength(4).WithMessage("İsim alanı 4 karakterden fazla olmalıdır");
            RuleFor(f => f.Name).MaximumLength(50).WithMessage("İsim alanı 50 karakterden az olmalıdır");
            RuleFor(f => f.Title).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(f => f.Title).MinimumLength(5).WithMessage("Meslek alanı 5 karakterden fazla olmalıdır");
            RuleFor(f => f.Title).MaximumLength(50).WithMessage("Meslek alanı 50 karakterden az olmalıdır");
        }
    }
}
