using sandhya_27.Models.DbContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Models.Models
{
    public class UserAddressModel
    {
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsDelete { get; set; }
        public int? Role { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }

        public string RoleType { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual States States { get; set; }
    }
}
