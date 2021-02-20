using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.ValidationRules
{
   public  class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarID).NotEmpty().WithMessage("Car ID boş geçilemez.");
            RuleFor(r => r.CustomerID).NotEmpty().WithMessage("Customer ID Boş geçilemez");
            RuleFor(r => r.RentalDate).NotEmpty().WithMessage("Rental Date Boş geçilemez");
            RuleFor(r => r.ReturnDate).NotEmpty().WithMessage("Return Date Boş geçilemez");
        }
    }
}
