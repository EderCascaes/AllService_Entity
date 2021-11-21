using Microsoft.AspNetCore.Mvc;

namespace AllService.WebApi_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrestadorController : ControllerBase
    {
        
          //todo Ilogger
        public PrestadorController()
        {
            
        }

        [HttpPost]
        public ActionResult Cadastrar()
        {
            return Ok("Cadastro Realizado com sucesso!");
        }

    }
}
