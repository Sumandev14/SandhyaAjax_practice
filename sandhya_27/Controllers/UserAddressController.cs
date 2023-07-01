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
    public class UserAddressController : Controller
    {
        // GET: UserAddress
        public UserAddressRepo _UserRepo;
        public UserAddressController(UserAddressRepo userAddressRepo)
        {
            _UserRepo = userAddressRepo;
        }
        Sandhya_380Entities1 _DBuser = new Sandhya_380Entities1();

        public ActionResult UserAddress(UserAddressModel userAddressModel)
        {
            List<Country> CountryList = _DBuser.Country.ToList();
            ViewBag.CountryList = new SelectList(CountryList, "CountryId", "CountryName");
            if (userAddressModel != null)
            {
                return View();
            }
            return View(userAddressModel);
        }
        public JsonResult AddUserAddress(int? id)
        {
            if(id == null)
            {
                return Json(JsonRequestBehavior.AllowGet);
            }
            else
            {
                var result = _UserRepo.GetUserAddressID(id);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult AddUserAddress(UserAddressModel userAddressModel, int? id)
        {
            if (ModelState.IsValid)
            {
                userAddressModel.IsDelete = true;
                if (id == null)
                {
                    _UserRepo.CreateUserAddress(userAddressModel, 0);
                    return Json(JsonRequestBehavior.AllowGet);
                }
                else
                {
                    var updateid = _UserRepo.CreateUserAddress(userAddressModel, id);
                    return Json(updateid, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetUserList(int? id)
        {
            var userList = _UserRepo.GetUserAddressList(id);
            return Json(userList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteUser(int id)
        {
             _UserRepo.DeleteUserAddress(id);
            return Json(JsonRequestBehavior.AllowGet);
        }



        public JsonResult GetStateName(int CountryId)
        {
            _DBuser.Configuration.ProxyCreationEnabled = false;
            List<States> stateList = _DBuser.States.Where(x => x.CountryId == CountryId).ToList();
            ViewBag.CountryList = new SelectList(stateList, "StateId", "StateName");
            return Json(stateList, JsonRequestBehavior.AllowGet);
        }
        public JsonResult getCityName(int stateId)
        {
            _DBuser.Configuration.ProxyCreationEnabled = false;
            List<City> cityList = _DBuser.City.Where(x => x.StateId == stateId).ToList();
            return Json(cityList, JsonRequestBehavior.AllowGet);
        }


    }
}
