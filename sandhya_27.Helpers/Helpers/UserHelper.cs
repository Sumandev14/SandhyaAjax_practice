using sandhya_27.Models.DbContext;
using sandhya_27.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Helpers.Helpers
{
    public class UserHelper
    {
        public static student createRegistration(UserModel userModel)
        {

            student stdRegistration = new student()
            {
                StdId = userModel.StdId,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                dateOfBirth = userModel.dateOfBirth,
                Mobile = userModel.Mobile,
                Country = userModel.Country,
                states = userModel.states,
                City = userModel.City,
                Email = userModel.Email,
                Password = userModel.Password,
                Role = userModel.Role
            };
            return stdRegistration;

        }

        public static UserModel gertRegistration(student student)
        {

            UserModel usermodel  = new UserModel()
            {
                StdId = student.StdId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                dateOfBirth = student.dateOfBirth,
                Mobile = student.Mobile,
                Country = student.Country,
                states = student.states,
                City = student.City,
                Email = student.Email,
                Password = student.Password,
                Role = student.Role
            };
            return usermodel;

        }
    }
}
