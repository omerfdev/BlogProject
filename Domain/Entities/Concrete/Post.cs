using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Abstract;
using Domain.Enum;

namespace Domain.Entities.Concrete
{
    public class Post : IBaseEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }    
        public Status Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Like>? Likes { get; set; }
        public Genre? Genres { get; set; }
        public int GenreID { get; set; }
        public int AppUserID { get; set; }
        public AppUser? AppUser { get; set; }

    }
}
