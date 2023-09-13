using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Comment:IBase
    {
        public string Content { get; set; }
        public int ID { get; set; }
        public bool IsActive { get; set ; }
        public DateTime CreateDate { get; set ; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}
