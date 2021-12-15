
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_net_core.Project.Modules.Blogs.Model.Entities;

namespace blog_net_core.Project.Modules.Blogs.Services
{
    //Interfaz del servicio para poder inyectar en controlador.
    public interface IBlogService
    {
        /// <summary>
        /// Get blog for id from BD.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Blog> getBlogById(int id);

        /// <summary>
        /// Add a new blog to BD.
        /// </summary>
        /// <param name="blog"></param>
        /// <returns></returns>
        Task<String> createBlog(Blog blog);

    }
}
