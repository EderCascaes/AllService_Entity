using Microsoft.AspNetCore.Mvc;
using System;

namespace AllService.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrestadorController : AppBaseController
    {
        
          //todo Ilogger
        public PrestadorController(IServiceProvider serviceProvider): base(serviceProvider)
        {            
        }

        [HttpPost]
        public ActionResult Cadastrar()
        {
            return Ok("Cadastro Realizado com sucesso!");
        }

    }
}
