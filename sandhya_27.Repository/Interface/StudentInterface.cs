using sandhya_27.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Repository.Interface
{
    public interface StudentInterface
    {
        IEnumerable<stdentModel> GetStdList(int? id, int PageNumber = 1);

        bool createStudent(stdentModel stdentModel, int? id);

        stdentModel GetStdById(int? id);

        void deleteStd(int id);
    }
}
