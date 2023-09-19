using Blog_ApplicationLayer.Models.Dto;
using Blog_ApplicationLayer.Services.AppUserService;
using Domain.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
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
            if (result.Succeeded) { return Content("Basarılı"); }
            return Content("Basarısız");

        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto register)
        {
         
                var result = await _appUserService.RegisterAsync(register);
                
                if (result.Succeeded)
                {
                    
                    var loginResult = await _appUserService.LoginAsync(new LoginDto
                    {                      
                        Username = register.Username,
                        Password = register.Password
                    });
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            

            return View(register);
        }
    }
}


