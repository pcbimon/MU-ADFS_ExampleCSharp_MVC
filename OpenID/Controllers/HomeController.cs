using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenID.Models;

namespace OpenID.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                UserProfile profile = new UserProfile(new System.Security.Claims.ClaimsIdentity(User.Identity));
                //return Json(profile, JsonRequestBehavior.AllowGet);
                return View();
            }
            return View();
        }
    }
}