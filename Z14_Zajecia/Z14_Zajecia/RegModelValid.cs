using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Z14_Zajecia
{
    public class RegModelValid : AbstractValidator<RegistrationModel>
    {
        public RegModelValid()
        {
            this.CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(x => x.Email)
                .NotNull()
                .NotEmpty()
                .EmailAddress();
            RuleFor(x => x.Password)
                .NotNull()
                .NotEmpty()
                .MinimumLength(6)
                .Must(r => !(r == r.ToLower() || r == r.ToUpper()))
                .Matches(@"(.*[!@#$%^&*\-].*)+"); //http://regex101.com/
            RuleFor(x => x.Accept)
                .Must(x => x)
                .WithMessage("Wyraź zgodę na regulamin!!!");

        }
    }
}
