using ExternalModels.Library;
using FluentValidation;
using System;
using System.Linq;

namespace FluentValication.WebApi.Validators
{
    public class DeveloperValidator : AbstractValidator<Developer>
    {
        public DeveloperValidator()
        {
            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!")
                .Length(2, 25)
                .Must(IsValidName).WithMessage("{PropertyName} should be all letters.");
            RuleFor(p => p.LastName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!")
                .Length(2, 25)
                .Must(IsValidName).WithMessage("{PropertyName} should be all letters.");
            RuleFor(p => p.Email)
                .EmailAddress();
        }

        private bool IsValidName(string name)
        {
            return name.All(char.IsLetter);
        }
    }
}
