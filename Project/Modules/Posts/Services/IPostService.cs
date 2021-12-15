
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_net_core.Project.Modules.Posts.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace blog_net_core.Project.Modules.Posts.Services
{
    //Interfaz del servicio para poder inyectar en controlador.
    public interface IPostService
    {
        Task<List<Post>> getAllPosts();
        Task<Post> getPostById(int postId);
        Task<Post> addPost(Post post);
        Task<Post> updatePost(Post post,int id);
        Task<Post> delete(int id);
    }
}
