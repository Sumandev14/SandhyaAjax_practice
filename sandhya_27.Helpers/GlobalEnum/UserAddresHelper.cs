using sandhya_27.Models.DbContext;
using sandhya_27.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Helpers.GlobalEnum
{
    public class UserAddresHelper
    {
        public static UserAddress createUserAddress(UserAddressModel userAddressModel)
        {
            UserAddress userAddress = new UserAddress()
            {
                UserId = userAddressModel.UserId,
                UserName = userAddressModel.UserName,
                Email = userAddressModel.Email,
                Password = userAddressModel.Password,
                IsDelete = userAddressModel.IsDelete,
                Role = userAddressModel.Role,
                CountryId = userAddressModel.CountryId,
                StateId =  userAddressModel.StateId,
                CityId = userAddressModel.CityId,
            };
            return userAddress;
        }

        public static UserAddressModel getUserAddress(UserAddress userAddress)
        {
            UserAddressModel userAddressModel = new UserAddressModel()
            {
                UserId = userAddress.UserId,
                UserName = userAddress.UserName,
                Email = userAddress.Email,
                Password = userAddress.Password,
                IsDelete = userAddress.IsDelete,
                Role = userAddress.Role,
                CountryId = userAddress.CountryId,
                StateId = userAddress.StateId,
                CityId = userAddress.CityId,

            };
            return userAddressModel;
        }

        public static List<UserAddressModel> getUserList(List<UserAddress> userAddresses)
        {
            List<UserAddressModel> userAddressModels = new List<UserAddressModel>();
            foreach(var item in userAddresses)
            {
                UserAddressModel UserData = new UserAddressModel();
                UserData.UserId = item.UserId;
                UserData.UserName = item.UserName;
                UserData.Email = item.Email;
                UserData.Password = item.Password;
                UserData.IsDelete = item.IsDelete;
                UserData.Role = item.Role;
                UserData.CityId = item.CountryId;
                UserData.StateId = item.StateId;
                UserData.CityId = item.CityId;
                UserData.RoleType = (item.Role == 1) ? "Dean" : (item.Role == 2) ? "Teacher" : (item.Role == 3) ? "Student" : "";

                userAddressModels.Add(UserData);
            }
            return userAddressModels;
        }
    }
}
