using FluentValidation;
using TMDb.Client.Contracts;

namespace TMDb.Client.Validators
{
    public class IRatingValidator : AbstractValidator<IRating>
    {
        public IRatingValidator()
        {
            RuleFor(rating => rating.Rating).InclusiveBetween(0.5, 10.0);
        }
    }
}