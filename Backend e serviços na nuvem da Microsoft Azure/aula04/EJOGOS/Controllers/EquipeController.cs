using EJOGOS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOS.Controllers
{
    public class EquipeController : Controller
    {
        // IActionResult ele é apropriado para quando temos diversos tipos possiveis.

        //        Os tipos ActionResult representam vários códigos de status HTTP.Alguns tipos de retorno comuns nessa categoria são BadRequestResult(400), NotFoundResult(404) e OkObjectResult(200).

        //Codigos HTPP

        //[https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status]


        Equipe equipeModel = new Equipe();

      //  [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Equipe = equipeModel.LerEquipes();

            //ViewBag = RESERVA DE ESPACO PARA ARMAZENARMOS INFORMAÇOES PARA RECUPERAR NA VIEW

            //A ViewBag tem a função de "carregar" informações do Controller para a View.           


            return View();
        }

       [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection  formulario)
        {

            //criar um objeto equipe a partir do frontend (IFormCollection)

            Equipe nova_equipe = new Equipe();
            nova_equipe.IdEquipe = int.Parse(formulario["IdEquipe"]);
            nova_equipe.nome = formulario["Nome"];
            nova_equipe.Imagem = formulario["Imagem"];

            //chamar o metodo para cadastrar uma nova equipe.
            equipeModel.Criar(nova_equipe);

            //consultando as equipes cadastradas e atualizando a ViewBag;
            ViewBag.Equipe = equipeModel.LerEquipes();


            //vamos redirecionar o navegador para pagina de Equipe.
            return LocalRedirect("~/Equipe");

        }


        /*
         
        **RAZOR**

        Para que serve o Razor?

        **Razor** é uma sintaxe de marcação que lhe permite inserir código baseado em servidor (Visual Basic e C#) em páginas da web. O código baseado em servidor pode criar conteúdo web dinâmico em tempo real, enquanto uma página web é escrita para o navegador.

        DOCUMENTACAO MICROSOFT - ADD COMENTARIO NO CODIGO.

        (https://docs.microsoft.com/pt-br/aspnet/core/razor-pages/?view=aspnetcore-6.0&tabs=visual-studio)


         * */




    }
}
