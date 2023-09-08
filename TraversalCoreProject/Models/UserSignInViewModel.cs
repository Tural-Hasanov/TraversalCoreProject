using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="İstifadəçi adını daxil edin")]
        public string username { get; set; }
        [Required(ErrorMessage = "Şifrəni daxil edin")]
        public string password { get; set; }
    }
}
