using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Abstract;
using Domain.Enum;

namespace Domain.Entities.Concrete
{
    public class Genre : IBaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }     
        public Status Status { get; set ; }
        public DateTime? CreateDate { get ; set ; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public ICollection<Post>? Post { get; set; }
    }
}
