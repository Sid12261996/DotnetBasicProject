using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectBasic.Controllers.Signup
{
    public class SignupController : Controller
    {
        public const string V = "name";

        // GET: Signup
        public ActionResult Signup()
        {
            
            return View();
        }
        
        // GET: Signup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Signup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Signup/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

      //POST:Signup/Edit/5
        [HttpPost]
        public new ActionResult Profile(FormCollection collection)
        {
            try
            {
               // String user = collection.AllKeys.ToString();
                
                ViewData["name"] = collection.Keys[0].ToString();
                return View();
            }
            catch
            { 
                return View();
            }
        }

        // GET: Signup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Signup/Delete/5
        [HttpPost]
        public ActionResult Delete( FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
