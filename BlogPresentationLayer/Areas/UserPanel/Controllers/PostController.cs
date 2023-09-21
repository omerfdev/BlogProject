using AutoMapper;
using Blog_ApplicationLayer.Models.Dto;
using Blog_ApplicationLayer.Services.PostService;
using BlogPresentationLayer.Models.VM;
using Domain.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogPresentationLayer.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public PostController(IPostService postService, IMapper mapper, UserManager<AppUser> userManager)
        {
            _postService = postService;
            _mapper = mapper;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddPost()
        {
            var postDTO = _postService.CreatePostAsync().Result;
            CreatePostVM postVM = new CreatePostVM();
            List<GenreDto> genres = postDTO.Genres.ToList();
            SelectList items = new SelectList(genres, "Id", "Name");
            ViewBag.GenreList = items;
            return View(postVM);
        }

        [HttpPost]
        public async Task<IActionResult> AddPost(CreatePostVM post)
        {
            if (ModelState.IsValid)
            {
                CreatePostDto postDTO = new CreatePostDto();
                postDTO.Title = post.Title;
                postDTO.Content = post.Content;
                postDTO.GenreId = post.GenreId;
                string imageName = new Random().Next(1, 100000).ToString() + "_" + post.ImageFile.FileName;
                postDTO.ImagePath = imageName;
                FileStream fs = new FileStream("wwwRoot/Images/PostImages/" + imageName, FileMode.Create);
                await post.ImageFile.CopyToAsync(fs);
                fs.Close();
                AppUser user = await _userManager.GetUserAsync(User);
                postDTO.AppUserId = user.Id;
                await _postService.CreatePostAsync(postDTO);
                return View();
            }

            return View();
        }
    }
}
