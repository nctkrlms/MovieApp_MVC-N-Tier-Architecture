using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        UserManager um = new UserManager(new EFUserDal());
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            um.UserAddBL(user);
            return RedirectToAction("Login");
        }
        [HttpGet]
        public ActionResult Login()
        {
            
            
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var userSel = um.UserCheck(user);
            if(userSel!=null )
            {
                Session["UserId"] = userSel.UserId.ToString();
                Session["RoleId"] = userSel.RoleId.ToString();
				return RedirectToAction("Index", "Movie");
			}
            else
            {
               
            }
             return View();
        }
    }
}