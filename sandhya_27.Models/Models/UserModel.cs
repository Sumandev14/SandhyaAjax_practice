using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Models.Models
{
    public class UserModel
    {
        public int StdId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime? dateOfBirth { get; set; }
        public long? Mobile { get; set; }
        public string Country { get; set; }
        public string states { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string C_Password { get; set; }
        public int? Role { get; set; }
        public string RoleName { get; set; }
    }
}
