using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDto>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Xahish olunur bashligi bosh qoymayin");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Xahish olunur contenti bosh qoymayin");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Minimum 5 xakarter daxil edin");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Minimum 20 xakarter daxil edin");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Maksimum 50 xakarter daxil edin");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Maksimum 500 xakarter daxil edin");
        }
    }
}
