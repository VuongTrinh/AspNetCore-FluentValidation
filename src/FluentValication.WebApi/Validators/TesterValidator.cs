using ExternalModels.Library;
using FluentValidation;

namespace FluentValication.WebApi.Validators
{
    public class TesterValidator : AbstractValidator<Tester>
    {
        public TesterValidator()
        {
            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!")
                .Length(2, 25);
        }
    }
}
