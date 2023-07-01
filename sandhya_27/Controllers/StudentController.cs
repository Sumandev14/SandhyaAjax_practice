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
    public class StudentController : Controller
    {
        // GET: Student

        public StudentInterface _StudentInter;
        public StudentController(StudentInterface studentInterface)
        {
            _StudentInter = studentInterface;
        }
        public ActionResult StudentView(stdentModel stdentModel)
        {
            if(stdentModel == null)
            {
                return View();
            }
            return View(stdentModel);
        }

        public JsonResult GetList(int? id, int PageNumber = 1)
        {
            var getList = _StudentInter.GetStdList(id, PageNumber);
            int itemsPerPage = 4; 
            int totalItems = getList.Count(); 
            int totalPages = (int)Math.Ceiling((double)totalItems / itemsPerPage);

            ViewBag.TotalPages = totalPages; 

            return Json(getList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult createStudent(int? id)
        {
            try
            {
                if (id == null)
                {
                    return Json(JsonRequestBehavior.AllowGet);
                }
                else
                {
                    var edit = _StudentInter.GetStdById(id);
                    return Json(edit, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [HttpPost]
        public JsonResult createStudent(stdentModel stdentModel, int? id, string[] SelectedSubjects)
        {
                    stdentModel.Subject = string.Join(",", SelectedSubjects);
                    stdentModel.IsDelete = true;
            //if (ModelState.IsValid)
            //{
                if (id == null)
                {
                    var create = _StudentInter.createStudent(stdentModel, 0);
                    return Json(create, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    var create = _StudentInter.createStudent(stdentModel, id);
                    return Json(create, JsonRequestBehavior.AllowGet);
                }
            //}
            //return Json(stdentModel, JsonRequestBehavior.AllowGet);
        }

        public JsonResult deletestd(int id)
        {
             _StudentInter.deleteStd(id);
            return Json(JsonRequestBehavior.AllowGet);
        }
    }
}