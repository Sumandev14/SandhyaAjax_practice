using sandhya_27.Models.Models;
using sandhya_27.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sandhya_27.Controllers
{
    public class UserTestController : Controller
    {
        public UserTestInt _userTest;
        public UserTestController(UserTestInt userTestInt)
        {
            _userTest = userTestInt;
        }
        // GET: UserTest
     
        public ActionResult Index(UserCustomTest model)
        {
            if (model == null)
            {
                return View();
            }
            return View(model);
        }

        public JsonResult userTestList(int? id)
        {
            var userList = _userTest.GetUserTestList(id);
            return Json(userList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult createUserTest(int? id)
        {
            try
            {
                if(id == null)
                {

                    return Json(JsonRequestBehavior.AllowGet);
                }
                else
                {
                   var userId = _userTest.getUserTestId(id);
                    return Json(userId, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpPost]
        public ActionResult createUserTest(UserCustomTest userCustomTest, int? id)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    var userAdd = _userTest.createUserTest(userCustomTest, 0);
                    return Json(new { userAdd, success = true, message = "success." }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    var getUser = _userTest.createUserTest(userCustomTest, id);
                    return Json(getUser, JsonRequestBehavior.AllowGet);
                }
            }
            //return RedirectToAction("Index", "UserTest", new { model = userCustomTest });
            return Json(new {success= false , model=userCustomTest},JsonRequestBehavior.AllowGet);
        }

        public JsonResult deleteUser(int id)
        {
             _userTest.deleteUserTest(id);
            return Json(JsonRequestBehavior.AllowGet);
        }
    }
}