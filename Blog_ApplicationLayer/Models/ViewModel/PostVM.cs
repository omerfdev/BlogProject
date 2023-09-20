﻿using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ApplicationLayer.Models.ViewModel
{
    public class PostVM
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ImagePath { get; set; }
        public int GenreId { get; set; }
        public string? GenreName { get; set; }
        public int AppUserId { get; set; }
        public string UserName { get; set; }
        public DateTime CreateDate { get; set; }

        public List<Like> Likes { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
