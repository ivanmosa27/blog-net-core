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
        private readonly IBlogService _blogService;

        public PostsController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [Route("")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var posts = _blogService.getAllPosts();
            return Ok(posts);
        }

        [Route("{postId}")]
        [HttpGet]
        public IActionResult Get(int postId)
        {
            var post = _blogService.getPostById(postId); 
            return Ok(post);
        }

        [Route("post")]
        [HttpPost]
        public IActionResult Create(PostModel model)
        {
            var post = _blogService.createPost(model);
            return Ok(post);
        }

        [Route("update")]
        [HttpPut]
        public IActionResult Update(PostModel model)
        {
            var post = _blogService.updatePost(model);
            return Ok(post);
        }
        
        [Route("delete-bd/{postId}")]
        [HttpDelete]
        public IActionResult Delete(int postId)
        {
            var post = _blogService.deleteById(postId);
            return Ok(post);
        }

        [Route("soft-delete")]
        [HttpDelete]
        public IActionResult SoftDelete(PostModel model)
        {
            var post = _blogService.softDelete(model);
            return Ok(post);
        }

    }
}
