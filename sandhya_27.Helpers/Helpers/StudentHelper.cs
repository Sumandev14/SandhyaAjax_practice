using sandhya_27.Models.DbContext;
using sandhya_27.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Helpers.Helpers
{
    public class StudentHelper
    {
        public static List<stdentModel> getStudentListHelper(List<studentTable> stddent)
        {
            List<stdentModel> stdentModels = new List<stdentModel>();
            foreach (var std in stddent)
            {
                stdentModel stdData = new stdentModel();
                stdData.studentId = std.studentId;
                stdData.UserName = std.UserName;
                stdData.Email = std.Email;
                stdData.Password = std.Password;
                stdData.Mobile = std.Mobile;
                stdData.Gender = std.Gender;
                stdData.Subject = std.Subject;
                stdData.Address = std.Address;
                stdData.Role = std.Role;
                stdData.IsDelete = std.IsDelete;
                stdData.RoleType = (std.Role == 1) ? "Dean" : (std.Role == 2) ? "Teacher" : (std.Role == 3) ? "Student" : "";

                stdentModels.Add(stdData);
            }
            return stdentModels;
        }

        public static studentTable createStdHelper(stdentModel stdentModel)
        {
            studentTable studentTable = new studentTable()
            {
                studentId = stdentModel.studentId,
                UserName = stdentModel.UserName,
                Email = stdentModel.Email,
                Password = stdentModel.Password,
                Mobile = stdentModel.Mobile,
                Gender = stdentModel.Gender,
                Subject = stdentModel.Subject,
                Address = stdentModel.Address,
                Role = stdentModel.Role,
                IsDelete = stdentModel.IsDelete
            };
            return studentTable;
        }


        public static stdentModel GetStdHelper(studentTable studentTable)
        {
            stdentModel stdentModel = new stdentModel()
            {
                studentId = studentTable.studentId,
                UserName = studentTable.UserName,
                Email = studentTable.Email,
                Password = studentTable.Password,
                Mobile = studentTable.Mobile,
                Gender = studentTable.Gender,
                Subject = studentTable.Subject,
                Address = studentTable.Address,
                Role = studentTable.Role,
                IsDelete = studentTable.IsDelete
            };
            return stdentModel;
        }

    }
}
