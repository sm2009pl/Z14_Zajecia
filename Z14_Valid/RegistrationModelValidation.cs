using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z14_Valid
{
    public class RegistrationModelValidation : AbstractValidator<RegistrationModel>
    {
        public RegistrationModelValidation()
        {
            this.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(x => x.Email)
                .NotNull()
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotNull()
                .NotEmpty()
                .MinimumLength(8)
                .Must(y => !(y == y.ToLower() || y == y.ToUpper()))
                .Matches(@"(?=.*[$@!#%^&*:;,./?\|])(?=.*[0-9])");

            RuleFor(x => x.Accept)
                .Must(x => x)
                .WithMessage("Należy zaakceptować regulamin.");
        }
    }
}
