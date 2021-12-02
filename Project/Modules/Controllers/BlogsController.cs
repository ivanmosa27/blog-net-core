using blog_net_core.Project.Modules.Model.Entities;
using blog_net_core.Project.Modules.Services;
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
    public class BlogsController : ControllerBase
    {
        private readonly IBlogService _blogService;

        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var blog = await _blogService.getBlogById(id); 
            return Ok(blog);
        }

        [Route("blog")]
        [HttpPost]
        public async Task<ActionResult> Create(Blog blog)
        {
            var blogCreated = await _blogService.createBlog(blog);
            return Ok(blogCreated);
        }

    }
}
