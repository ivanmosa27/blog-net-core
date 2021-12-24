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
        /// <param name="blogService">
        /// The blog service to process the blogs requests
        /// </param>
        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        /// <summary>
        /// Get all Blogs.
        /// </summary>
        /// <param name="id">
        /// The id of the blog we want to collect.
        /// </param>
        /// <returns>
        /// Return the Blog searched.
        /// </returns>
        [Route("{id:int}")]
        [HttpGet]
        public async Task<Blog> Get(int id)
        {
            return await _blogService.getBlogById(id).ConfigureAwait(false); 
            
        }

        /// <summary>
        /// Create a new Blog.
        /// </summary>
        /// <param name="blog">
        /// The structure of the Blog for create new Blog.
        /// </param>
        /// <returns>
        /// Returns the Blog created.
        /// </returns>
        [Route("")]
        [HttpPost]
        public async Task<Blog> Create(Blog blog)
        {
            return await _blogService.createBlog(blog).ConfigureAwait(false);
            
        }

    }
}
