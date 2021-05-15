using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Intranet_ColegioPrivado.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
         public ActionResult Login(string username,string password)
        {
            try
            {
                return RedirectToAction("Principal","Login");
            }
            catch (Exception ex)
            {

            }
            return View();
        }

        public ActionResult Principal()
        {
            return View();
        }
    }
}