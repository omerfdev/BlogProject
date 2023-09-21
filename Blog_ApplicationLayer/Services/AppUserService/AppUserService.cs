using AutoMapper;
using Blog_ApplicationLayer.Models.Dto;
using Domain.Entities.Concrete;
using Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ApplicationLayer.Services.AppUserService
{
    public class AppUserService : IAppUserService
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly IAppUserRepository _userRepository;
        private readonly IMapper _mapper;
        public AppUserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper, IAppUserRepository userRepository = null)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _userRepository = userRepository;
        }
        public async Task<SignInResult> LoginAsync(LoginDto login)
        {
            AppUser user = await _userRepository.GetFirstOrDefaultAsync(x => x.UserName == login.Username);
           return await _signInManager.PasswordSignInAsync(user, login.Password,false,false);        
        }

        public async Task Logout()
        {
          await  _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> RegisterAsync(RegisterDto register)
        {
            AppUser user = new AppUser();
            //user.FirstName = register.Firstname;
            //user.LastName = register.Lastname;
            //user.Email = register.Email;
          
            //user.ImagePath = register.ImagePath;
            _mapper.Map(register,user);
            user.UserName = register.Email;
            //user.PasswordHash = new PasswordHasher<AppUser>().HashPassword(user,register.Password);

            var result = await _userManager.CreateAsync(user, register.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                //Add a  Role for the user...(USER)
                await _userManager.AddToRoleAsync(user, "User");
            }
            return result;
        }
        public async Task<IdentityResult> KayıtAsync(KayıtDto register)
        {
            AppUser user = new AppUser();
            //user.FirstName = register.Firstname;
            //user.LastName = register.Lastname;
            //user.Email = register.Email;
            //user.ImagePath = register.ImagePath;
            _mapper.Map(register, user);
            user.UserName = register.Eposta;
            //user.PasswordHash = new PasswordHasher<AppUser>().HashPassword(user,register.Password);

            var result = await _userManager.CreateAsync(user, register.Sifre);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                //Add a  Role for the user...(USER)
                await _userManager.AddToRoleAsync(user, "User");
            }
            return result;
        }
    }
}
