using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator:AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Xanasını Boş Buraxmayın");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Mövzu Xanasını Boş Buraxmayın");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Xanasını Boş Buraxmayın");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj Xanasını Boş Buraxmayın");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Mövzu Xanasına minimum 5 xaraker daxil olunmalıdı");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Mövzu Xanasına maksimum 100 xaraker daxil olunmalıdı");

        }
    }
}
