using RegisAndLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegisAndLogin.Controllers
{
    public class UserController : Controller
    {
        //Thao tac dang ky:
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration([Bind(Exclude = "question1, answer1")] user user)
        {
            //Save data to database
            #region Save to Database
            using (NhapmonATTTEntities dc = new NhapmonATTTEntities())
            {
                dc.users.Add(user);
                dc.SaveChanges();
            }
           return View(user);
        }
        //Login

        //Login Post

        //Logout
    }
}