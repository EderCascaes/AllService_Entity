using Microsoft.AspNetCore.Mvc;
using System;

namespace AllService.WebApi.Controllers
{
    public class AppBaseController : ControllerBase
    {

        protected readonly IServiceProvider ServiceProvider;
          
        public AppBaseController(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

    }
}
