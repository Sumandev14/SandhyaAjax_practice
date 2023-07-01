using sandhya_27.Models.DbContext;
using sandhya_27.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Helpers.Helpers
{
    public class UserTestHelper
    {
        Sandhya_380TestEntities _DbTest = new Sandhya_380TestEntities();
        public static UserCustomTest GetUserTest(Users users)
        {
            UserCustomTest userCustomTest = new UserCustomTest()
            {
                UserId = users.UserId,
                F_Name = users.F_Name,
                L_Name = users.L_Name,
                Email = users.Email,
                Password = users.Password,
                Birth = users.Birth,
                BirthDOB = users.Birth.Value.ToString("dd/MM/yyyy"),
                Phone = users.Phone,
                Gender = users.Gender,
                Role = users.Role,
                IsDelete = users.IsDelete,
            };
            return userCustomTest;
        }

        public static Users CreateUserTest(UserCustomTest userCustomTest)
        {
            Users users = new Users()
            {
                UserId = userCustomTest.UserId,
                F_Name = userCustomTest.F_Name,
                L_Name = userCustomTest.L_Name,
                Email = userCustomTest.Email,
                Password = userCustomTest.Password,
                Birth = userCustomTest.Birth,
                Phone = userCustomTest.Phone,
                Gender = userCustomTest.Gender,
                Role = userCustomTest.Role,
                IsDelete = userCustomTest.IsDelete,
            };
            return users;
        }

        public static List<UserCustomTest> getUserTestList(List<Users> users)
        {
            List<UserCustomTest> userCustomTest = new List<UserCustomTest>();
            foreach(var item in users)
            {
                UserCustomTest userData = new UserCustomTest();
                userData.UserId = item.UserId;
                userData.F_Name = item.F_Name;
                userData.L_Name = item.L_Name;
                userData.Email = item.Email;
                userData.Password = item.Password;
                userData.Birth = item.Birth;
                userData.BirthDOB = item.Birth.Value.ToString("dd/MM/yyyy");
                userData.Phone = item.Phone;
                userData.Gender = item.Gender;
                userData.IsDelete = item.IsDelete;
                userData.Role = item.Role;
                userData.RoleType = (item.Role == 1) ? "Teacher" : (item.Role == 2) ? "Student" : "";
                userData.IsDelete = item.IsDelete;

                    userCustomTest.Add(userData);
            }
                return userCustomTest;
        }
    }
}
