using blog_net_core.Project.Modules.Blogs.Model.Entities;
using blog_net_core.Project.Modules.Blogs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_net_core.Controllers
{
    [Route("blogs")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogService _blogService;

        /// <summary>
        /// The constructor of the BlogController.
        /// </summary>
        /// <param name="blogService"></param>
        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        /// <summary>
        /// Get all Blogs.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id:int}")]
        [HttpGet]
        public async Task<ActionResult> Get(int id)
        {
            var blog = await _blogService.getBlogById(id); 
            return Ok(blog);
        }

        /// <summary>
        /// Create a new Blog.
        /// </summary>
        /// <param name="blog"></param>
        /// <returns></returns>
        [Route("")]
        [HttpPost]
        public async Task<ActionResult> Create(Blog blog)
        {
            var blogCreated = await _blogService.createBlog(blog);
            return Ok(blogCreated);
        }

    }
}
