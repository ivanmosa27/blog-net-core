using blog_net_core.EF;
using blog_net_core.Models;
using blog_net_core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetAll()
        {
            var posts = _postService.getAllPosts();
            return Ok(posts);
        }

        [Route("{postId}")]
        [HttpGet]
        public IActionResult Get(int postId)
        {
            var post = _postService.getPostById(postId); 
            return Ok(post);
        }

        [Route("post")]
        [HttpPost]
        public IActionResult Create(PostModel model)
        {
            var post = _postService.createPost(model);
            return Ok(post);
        }

        [Route("update")]
        [HttpPut]
        public IActionResult Update(PostModel model)
        {
            var post = _postService.updatePost(model);
            return Ok(post);
        }
        
        [Route("delete-bd/{postId}")]
        [HttpDelete]
        public IActionResult Delete(int postId)
        {
            var post = _postService.deleteById(postId);
            return Ok(post);
        }

        [Route("soft-delete")]
        [HttpDelete]
        public IActionResult SoftDelete(PostModel model)
        {
            var post = _postService.softDelete(model);
            return Ok(post);
        }

    }
}
