
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_net_core.Project.Modules.Blogs.Model.Entities;

namespace blog_net_core.Project.Modules.Blogs.Services
{
    
    public interface IBlogService
    {
        /// <summary>
        /// Get blog by id.
        /// </summary>
        /// <param name="id">
        /// The id of the blog we want to collect.
        /// </param>
        /// <returns>
        /// Return the Blog searched.
        /// </returns>
        Task<Blog> getBlogById(int id);

        /// <summary>
        /// Add a new blog to BD.
        /// </summary>
        /// <param name="blog">
        /// The structure of the Blog for create new Blog.
        /// </param>
        /// <returns>
        /// Return the Blog created.
        /// </returns>
        Task<Blog> createBlog(Blog blog);

    }
}
