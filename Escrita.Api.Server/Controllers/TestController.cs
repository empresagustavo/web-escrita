using Microsoft.AspNetCore.Mvc;

namespace Escrita.Api.Server.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        public TestController()
        {
                
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
