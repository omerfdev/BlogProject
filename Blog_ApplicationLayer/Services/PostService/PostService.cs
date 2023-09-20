using Blog_ApplicationLayer.Models.Dto;
using Blog_ApplicationLayer.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ApplicationLayer.Services.PostService
{
    public class PostService : IPostService
    {
        public Task CreatePost(CreatePostDto post)
        {
            throw new NotImplementedException();
        }

        public Task<CreatePostDto> CreatePost()
        {
            throw new NotImplementedException();
        }

        public Task DeletePost(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostVM>>? GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public Task<PostVM>? GetPost(int postID)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdatePost(UpdatePostDto post)
        {
            throw new NotImplementedException();
        }
    }
}
