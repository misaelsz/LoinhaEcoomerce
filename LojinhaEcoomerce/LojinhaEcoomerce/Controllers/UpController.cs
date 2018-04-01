using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojinhaEcoomerce.Controllers
{
    public class UpController : Controller
    {
        // GET: Up
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RecebeArquivo(HttpPostedFileBase file) {


            if(file != null)
            {
                return RedirectToRoute("Home/Index");
            }
            return View("Index");
        }
    }
}