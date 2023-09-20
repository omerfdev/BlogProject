using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ApplicationLayer.Models.Dto
{
    public class CreatePostDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ImagePath { get; set; }
        public int GenreId { get; set; }
        public int AppUserId { get; set; }
        List<GenreDTO>? Genres { get; set; }
    }
}
