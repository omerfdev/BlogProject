using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ApplicationLayer.Models.Dto
{
    public class RegisterDto
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string ImagePath { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Şifre ve Şifre Onayı alanları uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
        public IFormFile Image { get; set; }
    }
}
