using Microsoft.AspNetCore.Mvc;

namespace BaseApp.Controllers
{

    [ApiController]
    [Route("api/basis")]
    public class BaseController : ControllerBase
    {

        [HttpGet]
        [Route("first-index")]
        public IActionResult Index()
        {
            return Ok("first index result");
        }

        [HttpGet]
        [Route("second-index")]
        public IActionResult Index(int id)
        {

            return Ok("Second Index result");
        }

        [HttpGet]
        [Route("third-index")]
        public IActionResult Index(int id, int uid)
        {

            return Ok("Third index result");
        }

    }
}
