using AutoMapper;
using Blog_ApplicationLayer.Models.Dto;
using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ApplicationLayer.AutoMapper
{
    public class BlogMapper : Profile
    {
        public BlogMapper()
        {
            //Property adı aynı ise
            CreateMap<AppUser, RegisterDto>().ReverseMap();
            //türkçe property ile    
            CreateMap<AppUser, KayıtDto>().ForMember(x => x.Ad, x => x.MapFrom(y => y.FirstName)).
                ForMember(x => x.Soyad, x => x.MapFrom(y => y.LastName)).
                ForMember(x => x.Eposta, x => x.MapFrom(y => y.Email)).
                ForMember(x => x.ResimYolu, x => x.MapFrom(y => y.ImagePath)).
                ForMember(x => x.KullaniciAdi, x => x.MapFrom(y => y.Email)).
                ForMember(x => x.Sifre, x => x.MapFrom(y => y.PasswordHash)).ReverseMap();
        }
    }
}
