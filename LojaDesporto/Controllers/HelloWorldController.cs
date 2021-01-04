using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LojaDesporto.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            int hora = DateTime.Now.Hour;

            string mensagem;
            if (hora >= 7 && hora < 12)
            {
                mensagem = "Bom dia";
            }
            else if (hora >= 12 && hora < 20)
            {
                mensagem = "Boa Tarde";

            }
            else
            {
                mensagem = "Boa Noite";
            }

            ViewBag.Mensagem = mensagem;

            return View();
        }

        public string BemVindo()
        {
            return "Bem Vindo!!!";
        }
    }
}
