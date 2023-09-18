using Blog.Infrastructure.Context;
using Domain.Entities.Abstract;
using Domain.Entities.Concrete;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class AppUserRepository:BaseRepository<AppUser>,IAppUserRepository
    {
        public AppUserRepository(BlogContext context):base(context) 
        {
            
        }
    }
}
