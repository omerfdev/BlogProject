using AutoMapper;
using Blog_ApplicationLayer.Models.Dto;
using Blog_ApplicationLayer.Models.ViewModel;
using Domain.Entities.Concrete;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ApplicationLayer.Services.PostService
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;

        public PostService(IPostRepository postRepository,
                           IGenreRepository genreRepository,
                           IMapper mapper)
        {
            _postRepository = postRepository;
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public async Task CreatePostAsync(CreatePostDto post)
        {
            Post newPost = new Post();
            _mapper.Map(post, newPost);

            await _postRepository.AddAsync(newPost);
        }

        public async Task<CreatePostDto> CreatePostAsync()
        {
            CreatePostDto newPost = new CreatePostDto();
            List<GenreDto> genres = new List<GenreDto>();
            var comingFromDbGenres = _genreRepository.GetAll().ToList();
            _mapper.Map(comingFromDbGenres, genres);
            newPost.Genres = genres;
            return newPost;
        }


        public Task DeletePostAsync(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostVM>> GetAllPostsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PostVM> GetPostAsync(int postID)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdatePostAsync(UpdatePostDto post)
        {
            throw new NotImplementedException();
        }
    }
}

