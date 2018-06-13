namespace ClassLibrary1.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("error")]
        public IActionResult Error()
        {
            return Ok("Error page");
        }
    }
}
