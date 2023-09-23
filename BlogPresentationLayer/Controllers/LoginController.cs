using Blog_ApplicationLayer.Models.Dto;
using Blog_ApplicationLayer.Services.AppUserService;
using Microsoft.AspNetCore.Mvc;

namespace BlogPresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAppUserService _appUserService;

        public LoginController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginDto login)
        {
            var result = await _appUserService.LoginAsync(login);
            if (result.Succeeded)
                return Redirect("~/Blog");
            //  return Content("Basarili");
          
            else
                return Content("Basarisiz");
        }

        public IActionResult Logout()
        {
            _appUserService.Logout();
            return Redirect("~/Blog");
            //return NoContent();
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(RegisterDto register)
        {
            await _appUserService.RegisterAsync(register);
            return RedirectToAction("Index", "Posts");
        }


     
    }
}
