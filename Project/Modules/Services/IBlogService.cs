
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_net_core.Project.Modules.Model.Entities;

namespace blog_net_core.Project.Modules.Services
{
    //Interfaz del servicio para poder inyectar en controlador.
    public interface IBlogService
    {
        Task<Blog> getBlogById(int id);
        Task<String> createBlog(Blog blog);

    }
}
