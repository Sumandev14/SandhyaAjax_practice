using sandhya_27.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Repository.Interface
{
    public interface IuserInterface
    {
        IEnumerable<UserModel> GetUserList();
        bool CreateUser(UserModel userModel, int? id);
        UserModel geteUserById(int? id);
        void DeleteUser(int id);
    }
}
