using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ApplicationLayer.Models.Dto
{
    public class KayıtDto
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string ResimYolu { get; set; }
        public string Eposta { get; set; }
        public string Tel { get; set; }
        public string Sifre { get; set; }
        [Compare("Sifre", ErrorMessage = "Şifre ve Şifre Onayı alanları uyuşmuyor.")]
        public string SifreTekrar { get; set; }
        public IFormFile ResimDosyası { get; set; }
    }
}
