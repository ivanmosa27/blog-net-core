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
        /// <param name="postService"></param>
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        /// <summary>
        /// Get all posts.
        /// </summary>
        /// <returns></returns>
        [Route("")]
        [HttpGet]
        public async Task<ActionResult<List<Post>>> GetAll()
        {
            var posts = await _postService.getAllPosts();
            return Ok(posts);
        }

        /// <summary>
        /// Get Post by ID.
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        [Route("{postId:int}")]
        [HttpGet]
        public async Task<Microsoft.AspNetCore.Mvc.ActionResult> Get(int postId)
        {
            var post = await _postService.getPostById(postId); 
            return Ok(post);
        }

        /// <summary>
        /// Create a new Post.
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        [Route("")]
        [HttpPost]
         public async Task<Microsoft.AspNetCore.Mvc.ActionResult> Create([FromBody] CreatePostDto createPostDto)
        {
            var postCreated = await _postService.addPost(createPostDto);
            return Ok(postCreated);

        }

        /// <summary>
        /// Update Post by ID.
        /// </summary>
        /// <param name="post"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("")]
        [HttpPut]
        public async Task<Microsoft.AspNetCore.Mvc.ActionResult> Update(Post post, int id)
        {
            var postUpdated = await _postService.updatePost(post,id);
            return Ok(postUpdated);
            
        }

        /// <summary>
        /// Delete Post by ID.
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        [Route("")]
        [HttpDelete]
        public async Task<Microsoft.AspNetCore.Mvc.ActionResult> SoftDelete(int postId)
        {
            var post = await _postService.delete(postId);
            return Ok(post);
        }

    }
}
