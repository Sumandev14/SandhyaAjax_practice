using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Models.Models
{
    public class UserCustomTest
    {
        public int UserId { get; set; }
        [Required(ErrorMessage="Please Enter your First Name")]
        public string F_Name { get; set; }

        [Required(ErrorMessage = "Please Enter your Last Name")]
        public string L_Name { get; set; }
        [Required(ErrorMessage = "Please Enter your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter your Password")]

        public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter your Email")]
        [Compare("Password", ErrorMessage ="password does not match")]
        public string C_Password { get; set; }
        [Required(ErrorMessage = "Please Enter your Date of Birth")]

        public System.DateTime? Birth { get; set; }
        [Required(ErrorMessage = "Please Enter your Number")]

        public string BirthDOB { get; set; }

        public long? Phone { get; set; }
        [Required(ErrorMessage = "Please select your gender")]

        public string Gender { get; set; }

        public int? Role { get; set; }
        public string RoleType { get; set; }
        [Required(ErrorMessage = "Please select your IsDelete type!!")]
        public bool? IsDelete { get; set; }
    }
}
