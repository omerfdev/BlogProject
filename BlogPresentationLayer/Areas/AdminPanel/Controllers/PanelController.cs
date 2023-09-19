using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogPresentationLayer.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize]
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
