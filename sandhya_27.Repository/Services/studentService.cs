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
    public class studentService : StudentInterface
    {
        Sandhya_380TestEntities _DbStd = new Sandhya_380TestEntities();
        public bool createStudent(stdentModel stdentModel, int? id)
        {
            var result = StudentHelper.createStdHelper(stdentModel);
            if(result != null)
            {
                if(id == 0)
                {
                    _DbStd.studentTable.Add(result);
                    _DbStd.SaveChanges();
                    return true;
                }
                else
                {
                       studentTable std = _DbStd.studentTable.FirstOrDefault(x => x.studentId == id);
                    if(std != null)
                    {
                        std.UserName = stdentModel.UserName;
                        std.Email = stdentModel.Email;
                        std.Password = stdentModel.Password;
                        std.Mobile = stdentModel.Mobile;
                        std.Gender = stdentModel.Gender;
                        std.Subject = stdentModel.Subject;
                        std.Address = stdentModel.Address;
                        std.Role = stdentModel.Role;
                        std.IsDelete = stdentModel.IsDelete;

                        _DbStd.SaveChanges();
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

        public void deleteStd(int id)
        {
            var delete = _DbStd.studentTable.Find(id);
            if(delete != null)
            {
                delete.IsDelete = !delete.IsDelete;
                _DbStd.SaveChanges();
            }
        }

        public stdentModel GetStdById(int? id)
        {
            studentTable studentTable = _DbStd.studentTable.Where(x => x.studentId == id).FirstOrDefault();
            stdentModel stdentModel = StudentHelper.GetStdHelper(studentTable);
            return stdentModel;
        }

        public IEnumerable<stdentModel> GetStdList(int? id, int PageNumber = 1)
        {
            List<stdentModel> stdentModels = new List<stdentModel>();
            if (id.HasValue)
            {
                var studentTable = _DbStd.studentTable.FirstOrDefault(x => x.studentId == id && x.IsDelete == true);
                if (studentTable != null)
                {
                    stdentModels.Add(StudentHelper.GetStdHelper(studentTable));
                }
            }
            else
            {
                var stdList = _DbStd.studentTable.Where(x => x.IsDelete == true).ToList();
                stdList = stdList.Skip((PageNumber - 1) * 4).Take(4).ToList();
                stdentModels = StudentHelper.getStudentListHelper(stdList);
            }
            return stdentModels;
        }
    }
}
