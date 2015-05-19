using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unio.Poc.Aplicacao;

namespace Unio.Poc.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ServicoAplicacao servico = new ServicoAplicacao();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Rendimentos:" + servico.CalcularRendimentoAplicacao(10);

            return View();
        }

        [HttpPost]
        public JsonResult About(string pValue)
        {
            return  Json("Rendimentos:" + servico.CalcularRendimentoAplicacao(decimal.Parse(pValue)), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}