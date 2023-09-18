﻿using Blog_ApplicationLayer.Models.Dto;
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
        public AppUserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IAppUserRepository userRepository = null)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userRepository = userRepository;
        }
        public async Task<SignInResult> LoginAsync(LoginDto login)
        {
            AppUser user = await _userRepository.GetFirstOrDefaultAsync(x => x.UserName == login.Username);
           return await _signInManager.PasswordSignInAsync(user, login.Password,false,false);        
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> RegisterAsync(RegisterDto register)
        {
            throw new NotImplementedException();
        }
    }
}