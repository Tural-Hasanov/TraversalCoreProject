using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Models
{
    public class ResetPasswordViewModel
    {
        [MaxLength(20, ErrorMessage = "Maximum 20 xarakter daxil oluna biler"), MinLength(5)]
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
