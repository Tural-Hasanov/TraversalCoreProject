using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Adinizi daxil edin");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyadinizi daxil edin");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail daxil edin");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Istifadeci adi daxil edin");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Shifrenizi daxil edin");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Shifrenizi tekrar daxil edin");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("En azi 5 xarakter daxil edin");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Maksimum 20 xarakter daxil edin");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Shifreler bir birinden ferqlidir");
        }
    }
}
