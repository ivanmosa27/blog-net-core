
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_net_core.Project.Modules.Model.Entities.Posts;
using blog_net_core.Project.Modules.Model.Repositories;

namespace blog_net_core.Project.Modules.Services
{
    //Interfaz del servicio para poder inyectar en controlador.
    public interface IPostService
    {
        List<Post> getAllPosts();
        Post getPostById(int id);
        Post createPost(PostModel model);
        Post updatePost(PostModel model);
        Post deleteById(int id);
        Post softDelete(PostModel model);
    }
}
