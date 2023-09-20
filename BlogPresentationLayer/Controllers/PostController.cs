using Microsoft.AspNetCore.Mvc;

namespace BlogPresentationLayer.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
