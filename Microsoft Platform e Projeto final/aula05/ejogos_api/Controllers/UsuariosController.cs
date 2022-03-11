using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ejogos_api.Controllers
{
    //caminho de acesso para a controller.
    [Route("api/[controller]")]
    [ApiController]


    // : herança ControllerBase
    public class UsuariosController : ControllerBase
    {

        //modificador de acesso
        //o que vai retornar
        //nome do metodo
        //se vai receber parametros ou nao.

        //verbo
        [HttpGet]

        //complemento da rota
        [Route("localizar")]
        public IActionResult localizar()
        {

            //IActionResult -> HTTSTATUS ->

            return Ok("Localizar todos os usuario"); //200           
            
            //return BadRequest(); //400
        }

        //IActionResult -  HTTPSTATUS


        [HttpPost]
        //complemento da rota
        [Route("cadastrar")]
        public IActionResult cadastrar([FromBody] Usuario usuario) //objeto usuario
        {

            return Ok("Cadastar usuario novo"); //200           

        }


        public class Usuario
        {
            public string nome { get; set; }

        }


        }
}
