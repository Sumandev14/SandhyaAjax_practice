using sandhya_27.Helpers.Helpers;
using sandhya_27.Models.DbContext;
using sandhya_27.Models.Models;
using sandhya_27.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Repository.Services
{
    public class UserTestService : UserTestInt
    {
        Sandhya_380TestEntities _DbTest = new Sandhya_380TestEntities();

        public bool createUserTest(UserCustomTest userCustomTest, int? id)
        {
            Users users = UserTestHelper.CreateUserTest(userCustomTest);
            if(users != null)
            {
                if(id == 0)
                {
                    _DbTest.Users.Add(users);
                    _DbTest.SaveChanges();
                    return true;
                }
                else
                {
                    //_DbTest.Entry(userCustomTest).State = System.Data.Entity.EntityState.Modified;
                    //_DbTest.SaveChanges();
                    //return true;
                    Users existingUser = _DbTest.Users.FirstOrDefault(u => u.UserId == id);
                    if (existingUser != null)
                    {
                        existingUser.F_Name = userCustomTest.F_Name;
                        existingUser.L_Name = userCustomTest.L_Name;
                        existingUser.Email = userCustomTest.Email;
                        existingUser.Password = userCustomTest.Password;
                        existingUser.Birth = userCustomTest.Birth;
                        existingUser.Phone = userCustomTest.Phone;
                        existingUser.Gender = userCustomTest.Gender;
                        existingUser.Role = userCustomTest.Role;
                        existingUser.IsDelete = userCustomTest.IsDelete;

                        _DbTest.SaveChanges();
                        return true;
                    }
                    return false;
                }
       
            }
            else
            {
                return false;
            }
        }

        public void deleteUserTest(int id)
        {
                var user = _DbTest.Users.Find(id);
                if (user != null)
                {
                    user.IsDelete = !user.IsDelete;
                    _DbTest.SaveChanges();
                }
        }

        public UserCustomTest getUserTestId(int? id)
        {
            Users users = _DbTest.Users.Where(x => x.UserId == id).FirstOrDefault();
            UserCustomTest userCustomTest = UserTestHelper.GetUserTest(users);
            return userCustomTest;
        }

       

        public IEnumerable<UserCustomTest> GetUserTestList(int? id)
        {
            List<UserCustomTest> userCustomTest = new List<UserCustomTest>();

            if (id.HasValue)
            {
                var user = _DbTest.Users.FirstOrDefault(x => x.UserId == id && x.IsDelete == true);
                if (user != null)
                {
                    userCustomTest.Add(UserTestHelper.GetUserTest(user));
                }
            }
            else
            {
                var userList = _DbTest.Users.Where(x => x.IsDelete == true).ToList();
                userCustomTest = UserTestHelper.getUserTestList(userList);
            }

            return userCustomTest;
        }

    }
}
