using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectBasic.Properties;
using ProjectBasic.Models;

namespace ProjectBasic.Controllers.Signup
{
    public class SignupController : Controller
    {
        


        public UserModel usr = new UserModel();
        public SignupController()
        {

        }
        public  ActionResult Signup() {
            return View();
        }

        //POST:Signup/Profile/5
        [HttpPost]
        public ActionResult Signup(UserCredential user)
        {
            usr.Users.Insert(user);

            return RedirectToAction("Profile");
        }
        public new ActionResult Profile() {
            var disp = usr.Users.FindAll();
            return View(disp);
        }
       
    }
}
