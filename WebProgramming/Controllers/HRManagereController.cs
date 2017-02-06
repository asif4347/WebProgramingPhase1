using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProgramming.Controllers
{
    public class HRManagereController : Controller
    {
        // GET: HRManagere
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ComposeEmail()
        {
            return View();
        }
        public ActionResult CreateRole()
        {
            return View();
        }
        public ActionResult Applicants()
        {
            return View();
        }

    }
}