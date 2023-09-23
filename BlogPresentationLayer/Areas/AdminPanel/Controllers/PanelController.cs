using Blog_ApplicationLayer.Services.PostService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogPresentationLayer.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize]
    public class PanelController : Controller
    {
        private readonly IPostService _postService;
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> DeletePost(int id)
        {
            await _postService.DeletePostAsync(id);
            return Redirect("~/Blog");
        }
    }
}
