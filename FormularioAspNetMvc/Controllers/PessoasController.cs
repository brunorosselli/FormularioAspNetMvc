using FormularioAspNetMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FormularioAspNetMvc.Controllers
{
    public class PessoasController : Controller
    {
		private CadastroContext db = new CadastroContext();
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarPessoa(Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return View("Cadastro", pessoa);
            }

			db.Pessoas.Add(pessoa);
			db.SaveChanges();

			return RedirectToAction("Sucesso");
        }

		public ActionResult Sucesso()
		{
			return View();
		}

		public JsonResult ValidarCPF(string cpf)
		{
			var pessoa = db.Pessoas.Find(cpf);
			return Json(pessoa == null, JsonRequestBehavior.AllowGet);
		}
    }
}