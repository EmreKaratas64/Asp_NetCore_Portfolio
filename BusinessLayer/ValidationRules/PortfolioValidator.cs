using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Proje adı boş geçilemez");
            RuleFor(p => p.Name).MinimumLength(4).WithMessage("Proje adı 4 karakterden az olamaz");
            RuleFor(p => p.Name).MaximumLength(50).WithMessage("Proje adı 50 karakterden fazla olamaz");
            RuleFor(p => p.ImageUrl).NotEmpty().WithMessage("Proje fotoğrafı boş geçilemez");
            RuleFor(p => p.ImageUrl2).NotEmpty().WithMessage("Proje slider fotoğrafı boş geçilemez");
            RuleFor(p => p.ImageUrl2).NotEmpty().WithMessage("Proje slider fotoğrafı boş geçilemez");
            RuleFor(p => p.ProjectUrl).NotEmpty().WithMessage("Proje linki boş geçilemez");
            RuleFor(p => p.Price).NotEmpty().WithMessage("Proje fiyatı boş geçilemez");
            RuleFor(p => p.Value).NotEmpty().WithMessage("Proje tamamlanma oranı boş geçilemez");
        }
    }
}
