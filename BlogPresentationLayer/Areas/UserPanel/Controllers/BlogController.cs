using Blog_ApplicationLayer.Services.PostService;
using Microsoft.AspNetCore.Mvc;

namespace BlogPresentationLayer.Areas.UserPanel.Controllers
{
    
    public class BlogController : Controller
    {
        private readonly IPostService _postService;

        public BlogController(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<IActionResult> Index()
        {
        var allPosts=  await  _postService.GetAllPostsAsync();
            return View(allPosts);
        }
    }
}
