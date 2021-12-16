using Microsoft.EntityFrameworkCore;
using blog_net_core.Project.Modules.Posts.Model.Entities;
using blog_net_core.Project.Modules.Posts.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace blog_net_core.Project.Modules.Posts.Services{

    public class postService : IPostService{

        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper mapper;

        public postService(ApplicationDbContext dbContext, IMapper mapper)
        {

            _dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<List<Post>> getAllPosts()
        {
            return await _dbContext.Posts.ToListAsync();
        }

        public async Task<Post> getPostById(int postId)
        {
            return await _dbContext.Posts.FirstOrDefaultAsync(x => x.PostId == postId);    
        }
        
        public async Task<Post> addPost(CreatePostDto createPostDto)
        {
            var post = mapper.Map<Post>(createPostDto);
            _dbContext.Add(post);
            post.CreatedAt = DateTime.Today;
            await _dbContext.SaveChangesAsync();
            return post;
        }

        public async Task<Post> updatePost(Post post, int id)
        {
            _dbContext.Update(post);
            post.UpdatedAt = DateTime.Today;
            await _dbContext.SaveChangesAsync();
            return post;
        }
        public async Task<Post> delete(int id)
        {
            var post = await _dbContext.Posts.FirstOrDefaultAsync(x => x.PostId == id);
            post.DeletedAt = DateTime.Today;
            _dbContext.Update(post);
            await _dbContext.SaveChangesAsync();
            return post;
        }
    }
}