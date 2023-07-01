using sandhya_27.Models.DbContext;
using sandhya_27.Models.Models;
using sandhya_27.Repository.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_27.Repository.Services
{
    public class QuizService : IQuizInterface
    {
        Sandhya_380TestEntities _dbContext = new Sandhya_380TestEntities();
        public QuizService()
        {
            _dbContext.Configuration.ProxyCreationEnabled = false;
        }
        public IEnumerable<Answer> getAnswerList()
        {
            return _dbContext.Answer.ToList();
        }

        public IEnumerable<Questions> getQuistionList()
        {
            return _dbContext.Questions.ToList();
        }
    }
}
