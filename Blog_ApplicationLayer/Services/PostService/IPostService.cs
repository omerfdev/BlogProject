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
        Task CreatePost(CreatePostDto post);
        Task<CreatePostDto> CreatePost();
        Task<int> UpdatePost(UpdatePostDto post);

        Task DeletePost(int postId);

        Task<PostVM>? GetPost(int postID);
        Task<List<PostVM>>? GetAllPosts();
    }
}
