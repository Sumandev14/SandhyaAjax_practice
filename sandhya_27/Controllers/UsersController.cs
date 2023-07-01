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
    public class UsersController : Controller
    {
        public IuserInterface _iuserInter;
        public UsersController(IuserInterface iuserInterface)
        {
            _iuserInter = iuserInterface;
        }
        // GET: Users

        public ActionResult UserData()
        {
            return View();
        }
        public JsonResult ViewalluSERS()
        {
            IEnumerable<UserModel> userModelList = _iuserInter.GetUserList();
            return Json(userModelList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AddUser(int? id)
        {
            if (id == null)
            {
                return Json(JsonRequestBehavior.AllowGet);
            }
            else
            {
                UserModel userModel = _iuserInter.geteUserById(id);
                return Json(userModel, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult AddUser(UserModel userModel, int? id)
        {
            if (id == null)
            {
                bool created = _iuserInter.CreateUser(userModel, 0);
                return Json(new {created, success = true, message = "success." }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                bool updated = _iuserInter.CreateUser(userModel, id);
                return Json(new { updated, success = true, message = "success updated." }, JsonRequestBehavior.AllowGet);
            }
        }

        //public ActionResult deleteId(int id)
        //{
        //    _iuserInter.DeleteUser(id);
        //    return RedirectToAction("UserData");
        //}
       
       
    }
}