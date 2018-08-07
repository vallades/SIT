using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MelhorPrecoSempreIT.Controllers
{
    public class MelhorPrecoController : Controller
    {
        public ActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Buscar(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Buscar");
            }
            catch
            {
                return View();
            }
        }
    }
}
