using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Rehber Adini daxil edin");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Rehber aciqlamasini daxil edin");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Rehber goruntusunu daxil edin");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("30 xarakterden az daxil edin");
        }
    }
}
