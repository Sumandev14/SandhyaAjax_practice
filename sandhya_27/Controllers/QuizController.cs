using sandhya_27.Models.DbContext;
using sandhya_27.Models.Models;
using sandhya_27.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sandhya_27.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        public IQuizInterface _quizInter;
        public QuizController(IQuizInterface quizInterface)
        {
            _quizInter = quizInterface;
        }

        public JsonResult GetQuestion()
        {
            var li =_quizInter.getQuistionList();
            return Json(li,JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAnswer()
        {
            var li = _quizInter.getAnswerList();
            return Json(li,JsonRequestBehavior.AllowGet);
        }
        public ActionResult getData()
        {
            
            return View();
        }

       
        public ActionResult createTab()
        {
            return View();
        }

    }

}