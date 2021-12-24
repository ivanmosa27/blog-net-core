using blog_net_core.Project;
using blog_net_core.Project.Modules.Posts.Model.Entities;
using blog_net_core.Project.Modules.Posts.Services;
using blog_net_core.Project.Modules.Posts.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_net_core.Controllers
{
    [Route("posts")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
        
        /// <summary>
        /// The constructor of the PostController.
        /// </summary>
        /// <param name="postService">
        /// The post service will be used to create the posts synchronously.
        /// </param>
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        /// <summary>
        /// Get all posts.
        /// </summary>
        /// <returns>
        /// Return all posts.
        /// </returns>
        [Route("")]
        [HttpGet]
        public async Task<List<Post>> GetAll()
        {
            return await _postService.getAllPosts();
        }

        /// <summary>
        /// Get Post by ID.
        /// </summary>
        /// <param name="postId">
        /// The id of post searched.
        /// </param>
        /// <returns>
        /// Return the post searched by id.
        /// </returns>
        [Route("{postId:int}")]
        [HttpGet]
        public async Task<Post> Get(int postId)
        {
            return await _postService.getPostById(postId); 
        }

        /// <summary>
        /// Create a new Post.
        /// </summary>
        /// <param name="createPostDto">
        ///  The information about the Post to create.
        /// </param>
        /// <returns>
        /// Return the Post created.
        /// </returns>
        [Route("")]
        [HttpPost]
         public async Task<Post> Create([FromBody] CreatePostDto createPostDto)
        {
            return await _postService.addPost(createPostDto);
        }

        /// <summary>
        /// Update Post by ID.
        /// </summary>
        /// <param name="UpdatePostDto">
        /// The information about the Post to update.
        /// </param>
        /// <param name="id">
        /// The id to the post for update.
        /// </param>
        /// <returns>
        /// Return the post updated.
        /// </returns>
        [Route("")]
        [HttpPut]
        public async Task<Post> Update([FromBody] UpdatePostDto updatePostDto, int id)
        {
            return await _postService.updatePost(updatePostDto,id); 
        }

        /// <summary>
        /// Delete Post by ID.
        /// </summary>
        /// <param name="postId">
        /// The id of post searched.
        /// </param>
        /// <returns>
        /// The post Deleted.
        /// </returns>
        [Route("")]
        [HttpDelete]
        public async Task<Post> SoftDelete(int postId)
        {
            return await _postService.delete(postId);
        }
    }
}
