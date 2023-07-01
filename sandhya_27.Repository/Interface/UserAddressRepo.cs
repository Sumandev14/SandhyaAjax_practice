using sandhya_27.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Repository.Interface
{
    public interface UserAddressRepo
    {
        bool CreateUserAddress(UserAddressModel userAddressModel, int? id);

        IEnumerable<UserAddressModel> GetUserAddressList(int? id);

        UserAddressModel GetUserAddressID(int? id);

        void DeleteUserAddress(int id);
    }
}
