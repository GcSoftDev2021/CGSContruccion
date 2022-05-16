using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CGSContruccion.App.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        public ActionResult Empresa()
        {
            return View();
        }

        public ActionResult Crear_Empresa()
        {
            return View();
        }

        public ActionResult Editar_Empresa()
        {
            return View();
        }
    }
}