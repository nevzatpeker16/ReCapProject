using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.ValidationRules
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {

            RuleFor(p => p.BrandID).NotEmpty();
            RuleFor(p => p.ColorID).NotEmpty();
            RuleFor(p => p.DailyPrice).NotEmpty().WithMessage("Araba Fiyatı Boş olamaz.");
            RuleFor(p => p.DailyPrice).GreaterThan(0).WithMessage("Araba Fiyatı 0 Dan büyük olmalıdır.");
            RuleFor(p => p.Description).NotEmpty().WithMessage("Araba adı boş geçilemez.");
        }
    }
}
