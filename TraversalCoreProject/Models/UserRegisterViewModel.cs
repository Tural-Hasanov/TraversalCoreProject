using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Adinizi daxil edin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyadinizi daxil edin")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Istifadeci adini daxil edin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mail daxil edin")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Shifreni daxil edin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Tekrar shifreni daxil edin")]
        [Compare("ConfirmPassword")]
        public string ConfirmPassword { get; set; }
        
    }
}
