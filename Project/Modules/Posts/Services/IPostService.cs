
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_net_core.Project.Modules.Posts.Model.Entities;
using blog_net_core.Project.Modules.Posts.Dto;
using Microsoft.AspNetCore.Mvc;

namespace blog_net_core.Project.Modules.Posts.Services
{
    //Interfaz del servicio para poder inyectar en controlador.
    public interface IPostService
    {
        /// <summary>
        /// Get all the posts from the DB.
        /// </summary>
        /// <returns></returns>
        Task<List<Post>> getAllPosts();
        
        /// <summary>
        /// Get post for id from BD.
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        Task<Post> getPostById(int postId);

        /// <summary>
        /// Add new post to BD.
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        Task<Post> addPost(CreatePostDto createPostDto);

        /// <summary>
        /// Update post from BD.
        /// </summary>
        /// <param name="post"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Post> updatePost(Post post,int id);

        /// <summary>
        /// Delete a post from BD.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Post> delete(int id);
    }
}
