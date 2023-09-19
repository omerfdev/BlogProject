using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogPresentationLayer.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
   
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
