using Microsoft.EntityFrameworkCore;
using blog_net_core.Project.Modules.Posts.Model.Entities;
using blog_net_core.Project.Modules.Posts.Mappers;
using blog_net_core.Project.Framework;
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

        /// <inheritdoc > Implemented using the blog service interface.</inheritdoc>
        public async Task<List<Post>> getAllPosts()
        {
            return await _dbContext.Posts.ToListAsync();
        }

        /// <inheritdoc > Implemented using the blog service interface.</inheritdoc>
        public async Task<Post> getPostById(int postId)
        {
            return await _dbContext.Posts.FirstOrDefaultAsync(x => x.PostId == postId);
        }
        
        /// <inheritdoc > Implemented using the blog service interface.</inheritdoc>
        public async Task<Post> addPost(CreatePostDto createPostDto)
        {
            Post post = createPostDto.ToPost();
            post.CreatedAt = DateTime.Today;
            _dbContext.Add(post);
            await _dbContext.SaveChangesAsync();
            return post;
        }

        /// <inheritdoc > Implemented using the blog service interface.</inheritdoc>
        public async Task<Post> updatePost(UpdatePostDto updatePostDto, int id)
        {
            var post = await getPostById(id);
            post.MergeWithUpdatePost(updatePostDto);
            post.UpdatedAt = DateTime.Today;
            _dbContext.Update(post);
            await _dbContext.SaveChangesAsync();
            return post;
        }

        /// <inheritdoc > Implemented using the blog service interface.</inheritdoc>
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