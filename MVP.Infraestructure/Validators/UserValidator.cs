using FluentValidation;
using MVP.Core.DTOs;
using System;

namespace MVP.Infraestructure.Validators
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(user => user.Name)
                .NotNull()
                .Length(1, 30);
            RuleFor(user => user.BirthDate)
                .NotNull()
                .LessThan(DateTime.Now);
        }
    }
}
