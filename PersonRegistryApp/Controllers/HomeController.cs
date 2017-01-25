using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace PersonRegistryApp.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            //return View((User as ClaimsPrincipal).Claims);
            return View();
        }

        /*
         * For Securing Web APIs demo
         * Here am simply protecting the About action on the index page
         */
        [Authorize]
        public ActionResult About()
        {
            return View((User as ClaimsPrincipal).Claims);
        }
    }
}
