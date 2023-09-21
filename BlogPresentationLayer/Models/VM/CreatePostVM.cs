using BlogPresentationLayer.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogPresentationLayer.Models.VM
{
    public class CreatePostVM
    {
        public string Title { get; set; }
        public string Content { get; set; }
        //public string? ImagePath { get; set; }
        [ImageFileExtensionValidator]
        public IFormFile ImageFile { get; set; }
        public int GenreId { get; set; }
        //public int? AppUserId { get; set;
        public SelectList? Genres { get; set; }

    }
}
