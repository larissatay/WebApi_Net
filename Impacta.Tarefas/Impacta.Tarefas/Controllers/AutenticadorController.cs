using Impacta.MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Impacta.Tarefas.Controllers
{
    public class AutenticadorController : Controller
    {
        // GET: Autenticador
        public ActionResult Formulario()
        {
            return View();
        }

		public ActionResult Entar(Usuario usuario)
		{
			if (usuario.Username != null && usuario.Password != null && usuario.Username.Equals("Larissa") && usuario.Password.Equals("RealBooks"))
			{
				Session["Usuario"] = usuario;
				return RedirectToAction("Index", "RealBooks");
			}

		else
			{
				ViewBag.Mensagem = "usuário ou senha incorretos";
				return View("Formulario");
			}
		}

		public ActionResult Sair()
		{
			Session.Abandon();
			return RedirectToAction("Formulario", "Autenticador"); 
		}
    }
}