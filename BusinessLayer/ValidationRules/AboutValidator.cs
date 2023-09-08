using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Bosh xanani doldurun");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Shekil daxil edin");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("En azi 50 xarakter daxil edin");

        }

    }
}
