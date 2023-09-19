using Blog_ApplicationLayer.Models.Dto;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ApplicationLayer.Services.AppUserService
{
    public interface IAppUserService
    {
         Task<SignInResult> LoginAsync(LoginDto login);
        Task<IdentityResult> RegisterAsync(RegisterDto register);
        Task Logout();
    }
}
