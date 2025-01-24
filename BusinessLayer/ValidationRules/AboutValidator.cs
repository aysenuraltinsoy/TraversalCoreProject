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
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş geçilemez.");
            RuleFor(x=>x.ImageFirst).NotEmpty().WithMessage("Lütfen görsel seçiniz.");
            RuleFor(x=>x.Description).MaximumLength(1500).WithMessage("Maksimum karakter sınırına ulaştınız");
        }
    }
}
