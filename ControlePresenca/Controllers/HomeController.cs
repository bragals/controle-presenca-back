using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlePresenca.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            return Json(new { message = "Aplicação Iniciada" }, JsonRequestBehavior.AllowGet);
        }
    }
}
