using sandhya_27.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Repository.Interface
{
    public interface UserTestInt
    {
        IEnumerable<UserCustomTest> GetUserTestList(int? id);
        bool createUserTest(UserCustomTest userCustomTest, int? id);

        UserCustomTest getUserTestId(int? id);

        void deleteUserTest(int id);
    }
}
