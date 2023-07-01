using sandhya_27.Helpers.GlobalEnum;
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
    public class UserAddresservice : UserAddressRepo
    {
        Sandhya_380Entities1 _DBuser = new Sandhya_380Entities1();

        public void UserAddress()
        {
            _DBuser.Configuration.ProxyCreationEnabled = false;
        }
        public bool CreateUserAddress(UserAddressModel userAddressModel, int? id)
        {
            UserAddress user = UserAddresHelper.createUserAddress(userAddressModel);
            if (user != null)
            {
                if (id == 0)
                {
                    _DBuser.UserAddress.Add(user);
                    _DBuser.SaveChanges();
                    return true;
                }
                else
                {
                    UserAddress result = _DBuser.UserAddress.FirstOrDefault(x => x.UserId == id);
                    if (result != null)
                    {
                        result.UserName = userAddressModel.UserName;
                        result.Email = userAddressModel.Email;
                        result.Password = userAddressModel.Password;
                        result.Role = userAddressModel.Role;
                        result.CountryId = userAddressModel.CountryId;
                        result.StateId = userAddressModel.StateId;
                        result.CityId = userAddressModel.CityId;

                        _DBuser.SaveChanges();
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

        public void DeleteUserAddress(int id)
        {
            var delete = _DBuser.UserAddress.Find(id);
            if(delete != null)
            {
                delete.IsDelete = !delete.IsDelete;
                _DBuser.SaveChanges();
            }
        }

        public UserAddressModel GetUserAddressID(int? id)
        {
            UserAddress userAddress = _DBuser.UserAddress.Where(x => x.UserId == id).FirstOrDefault();
            UserAddressModel result = UserAddresHelper.getUserAddress(userAddress);
            return result;
        }

        public IEnumerable<UserAddressModel> GetUserAddressList(int? id)
        {
            List<UserAddressModel> userAddressModels = new List<UserAddressModel>();
            if (id.HasValue)
            {
                var UserList = _DBuser.UserAddress.FirstOrDefault(x => x.UserId == id && x.IsDelete == true);
                if (UserList != null)
                {
                    userAddressModels.Add(UserAddresHelper.getUserAddress(UserList));
                }
            }
            else
                {
                    var user = _DBuser.UserAddress.Where(x => x.IsDelete == true).ToList();
                     userAddressModels = UserAddresHelper.getUserList(user);
                }
            
            return userAddressModels;
        }
    }
}
