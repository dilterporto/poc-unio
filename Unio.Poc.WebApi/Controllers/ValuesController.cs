using Microsoft.AspNet.Mvc;

namespace Unio.Poc.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TesouroDiretoController : Controller
    {        
        // POST api/values        
        [Route("{value}")]
        public string Get(string value)
        {
            var valor = decimal.Parse(value);

            return (valor * 100).ToString(); 
        }
    }
}
