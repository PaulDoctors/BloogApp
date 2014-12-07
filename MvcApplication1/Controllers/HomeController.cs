using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult AddComment()
        {
            string Comment = Request.Form["Comment"];
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Index()
        {
            string query = Request.QueryString["Foo"];
            var model = new ArticlModel();
         
            return View(model);
        }

    }
}
