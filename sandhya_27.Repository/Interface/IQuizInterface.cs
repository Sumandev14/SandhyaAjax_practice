using sandhya_27.Models.DbContext;
using sandhya_27.Models.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Repository.Interface
{
    public interface IQuizInterface
    {
        IEnumerable<Questions> getQuistionList();

        IEnumerable<Answer> getAnswerList();
    }
}
