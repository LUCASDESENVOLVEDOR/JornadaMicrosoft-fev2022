using EJOGOS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOS.Controllers
{
    public class EquipeController : Controller
    {
        // IActionResult ele é apropriado para quando temos diversos tipos possiveis.

        //        Os tipos ActionResult representam vários códigos de status HTTP.Alguns tipos de retorno comuns nessa categoria são BadRequestResult(400), NotFoundResult(404) e OkObjectResult(200).

        //Codigos HTPP

        //[https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status](https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status)


        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            ViewBag.Lucas = equipeModel.LerEquipes();


            //ViewBag = RESERVA DE ESPACO PARA ARMAZENARMOS INFORMAÇOES PARA RECUPERAR NA VIEW

            //A ViewBag tem a função de "carregar" informações do Controller para a View. 
           


            return View();
        }
    }
}
