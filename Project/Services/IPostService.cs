using blog_net_core.Project.EF;
using blog_net_core.Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_net_core.Project.Services
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
