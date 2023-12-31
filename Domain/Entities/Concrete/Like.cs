﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Abstract;
using Domain.Enum;

namespace Domain.Entities.Concrete
{
    public class Like : IBaseEntity
    {
        public int ID { get; set; }    
        public Status Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int? AppUserID { get; set; }
        public AppUser? AppUser { get; set; }
        public int? PostID { get; set; }
        public Post? Post { get; set; }
    }
}
