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
            bool Status = false;
            string Message = "";
            if (ModelState.IsValid)
            {
                //Save data to database
                #region Save to Database
                using (NhapmonATTTEntities dc = new NhapmonATTTEntities())
                {
                    dc.users.Add(user);
                    dc.SaveChanges();
                }
                #endregion
            }
            else
            {
                Message = "Invalid request";
            }
            return View(user);
        }
        //Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        //Login Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLogin login)
        {
            string Message = "";
            using (NhapmonATTTEntities dc = new NhapmonATTTEntities())
            {
                var v = dc.users.Where(a => a.Username == login.Username).FirstOrDefault();
                if (v != null)
                {
                    if (string.Compare(v.answer1, login.Answer1) == 0 
                        && string.Compare(v.answer2, login.Answer2) == 0
                        && string.Compare(v.answer3, login.Answer3) == 0)
                    {
                       
                    }
                    else
                    {
                        Message = "Wrong answer";
                    }
                }
                else
                {
                    Message = "Invalid";
                }
            }
            ViewBag.Message = Message;
            return View();
        }
        //Logout
    }
}