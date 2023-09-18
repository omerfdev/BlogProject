using Blog.Infrastructure.Context;
using Domain.Entities.Abstract;
using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class GenreRepository:BaseRepository<Genre>
    {
        public GenreRepository(BlogContext context):base(context) 
        {
            
        }
    }
}
