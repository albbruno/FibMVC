using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FibMVC.Controllers
{
    public class FiboController : Controller
    {
        // GET: Fibo
        public ActionResult Index()
        {
            return View();
        }
    }
}