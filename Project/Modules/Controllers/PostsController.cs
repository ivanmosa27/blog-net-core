using blog_net_core.Project;
using blog_net_core.Project.Modules.Model.Entities;
using blog_net_core.Project.Modules.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_net_core.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
            
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [Route("")]
        [HttpGet]
        public async Task<ActionResult<List<Post>>> GetAll()
        {
            var posts = await _postService.getAllPosts();
            return Ok(posts);
        }

        [Route("{postId}")]
        [HttpGet]

        public async Task<ActionResult> Get(int postId)
        {
            var post = await _postService.getPostById(postId); 
            return Ok(post);
        }

    
        [Route("create")]
        [HttpPost]
         public async Task<ActionResult> Create(Post post)
        {
                var postCreated = await _postService.addPost(post);
                return Ok(postCreated);

        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update(Post post, int id)
        {
            var postUpdated = await _postService.updatePost(post,id);
            return Ok(postUpdated);
            
        }
        [HttpDelete("{postId:int}")]
        public async Task<ActionResult> SoftDelete(int postId)
        {
            var post = await _postService.delete(postId);
            return Ok(post);
        }

    }
}
