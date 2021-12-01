
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_net_core.Project.Modules.Model.Entities;
using blog_net_core.Project.Modules.Model.Repositories;

namespace blog_net_core.Project.Modules.Services
{
    //Interfaz del servicio para poder inyectar en controlador.
    public interface IPostService
    {
        List<Posts> getAllPosts();
        Posts getPostById(int id);
        Posts createPost(PostModel model);
        Posts updatePost(PostModel model);
        Posts deleteById(int id);
        Posts softDelete(PostModel model);
    }
}
