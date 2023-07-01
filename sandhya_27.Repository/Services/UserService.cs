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
    public class UserService : IuserInterface
    {
    Sandhya_380Entities _DbUser = new Sandhya_380Entities();
        public bool CreateUser(UserModel userModel, int? id)
        {
            student std = UserHelper.createRegistration(userModel);
            if(std != null)
            {
                if (id == 0)
                {
                    _DbUser.student.Add(std);
                    _DbUser.SaveChanges();
                    return true;
                }
                else
                {
                    _DbUser.Entry(userModel).State = System.Data.Entity.EntityState.Modified;
                    _DbUser.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public void DeleteUser(int id)
        {
            var delete = _DbUser.student.Find(id);
            _DbUser.student.Remove(delete);
            _DbUser.SaveChanges();
        }

        public UserModel geteUserById(int? id)
        {
            student student = _DbUser.student.Where(x => x.StdId == id).FirstOrDefault();
            UserModel userModel = UserHelper.gertRegistration(student);
            return userModel;
        }

        public IEnumerable<UserModel> GetUserList()
        {
            List<student> stdList = new List<student>();
            List<UserModel> userModelList = new List<UserModel>();
            stdList = _DbUser.student.ToList();
            foreach (var user in stdList)
            {
                UserModel std = new UserModel();
                std.StdId = user.StdId;
                std.FirstName = user.FirstName;
                std.LastName = user.LastName;
                std.dateOfBirth = user.dateOfBirth;
                std.Mobile = user.Mobile;
                std.Country = user.Country;
                std.states = user.states;
                std.City = user.City;
                std.Email = user.Email;
                std.Password = user.Password;
                std.Role = user.Role;
                std.RoleName = (user.Role == 1) ? "Principal" : (user.Role == 2) ? "Teacher" : (user.Role == 3) ? "Student" : "";

                userModelList.Add(std);
            }
            return userModelList;
        }
    }
}
