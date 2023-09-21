using Blog_ApplicationLayer.Models.Dto;
using Blog_ApplicationLayer.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ApplicationLayer.Services.PostService
{
    public interface IPostService
    {
        Task CreatePostAsync(CreatePostDto post);
        Task<CreatePostDto> CreatePostAsync();
        Task<int> UpdatePostAsync(UpdatePostDto post);

        Task DeletePostAsync(int postId);

        Task<PostVM> GetPostAsync(int postID);
        Task<List<PostVM>> GetAllPostsAsync();
    }
}
