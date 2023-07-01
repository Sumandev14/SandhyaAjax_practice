using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Models.Models
{
   public class stdentModel
    {
        public int studentId { get; set; }
        [Required(ErrorMessage = "Please enter your UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your Email")]
        [EmailAddress(ErrorMessage = "Please enter valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your Password")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password is not match")]
        public string ConformPassword { get; set; }
        [Required(ErrorMessage = "Please enter your Mobile")]
        [Phone(ErrorMessage = "Please enter valid phone")]
        public long? Mobile { get; set; }
        [Required(ErrorMessage = "Please enter your Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter your Subject")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Please enter your Address")]
        public string Address { get; set; }
        public int? Role { get; set; }

        public bool? IsDelete { get; set; }
        [Required(ErrorMessage = "Please enter your RoleType")]
        public string RoleType { get; set; }

         
    }
}
