using FibMVC.Models;
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

        public ActionResult FiboPage()
        {

            return View();
        }

        [HttpGet]
        public PartialViewResult FiboPartial()
        {
            //FibonacciMdl fMdl = new FibonacciMdl();
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult FiboPartial(FibonacciMdl fMdl)
        {
            return PartialView(fMdl);
        }
    }
}