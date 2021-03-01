using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.ValidationRules
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("First name boş olamaz");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Last name boş olamaz");
            //RuleFor(u => u.Password).NotEmpty().WithMessage("Password boş olamaz");
            
        }
    }
}
