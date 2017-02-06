using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProgramming.Controllers
{
    public class SMEController : Controller
    {
        // GET: SME
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Email()
        {
            return View();
        }
        public ActionResult ComposeEmail()
        {
            return View();
        }
        public ActionResult Applicants()
        {
            return View();
        }


    }
}