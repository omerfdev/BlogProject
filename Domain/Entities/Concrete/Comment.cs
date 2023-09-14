using Domain.Entities.Abstract;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrete
{
    public class Comment : IBaseEntity
    {
        public int ID { get; set; }
        public string Content { get; set; }    
        public Status Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int AppUserID { get; set; }
        public AppUser? AppUser { get; set; }
        public int PostID { get; set; }
        public Post? Post { get; set; }
    }
}
