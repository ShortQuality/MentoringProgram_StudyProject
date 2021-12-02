using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MP_OnlineStore.WEB.ViewModels;

namespace MP_OnlineStore.WEB.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        [Route("edit")]
        public IActionResult Edit([FromBody]ProductViewModel model)
        {
            return Ok();
        }
    }
}
