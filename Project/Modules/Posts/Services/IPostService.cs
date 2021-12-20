
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_net_core.Project.Modules.Posts.Model.Entities;
using blog_net_core.Project.Modules.Posts.Dto;
using Microsoft.AspNetCore.Mvc;

namespace blog_net_core.Project.Modules.Posts.Services
{
    public interface IPostService
    {
        /// <summary>
        /// Get all the posts from the DB.
        /// </summary>
        /// <returns>
        /// Return a List of all posts.
        /// </returns>
        Task<List<Post>> getAllPosts();
        
        /// <summary>
        /// Get post for id from BD.
        /// </summary>
        /// <param name="postId">
        /// The id of post searched.
        /// </param>
        /// <returns>
        /// Return the post searched by id.
        /// </returns>
        Task<Post> getPostById(int postId);

        /// <summary>
        /// Add new post to BD.
        /// </summary>
        /// <param name="createPostDto">
        /// The information about the Post to create.
        /// </param>
        /// <returns>
        /// Return the post created.
        /// </returns>
        Task<Post> addPost(CreatePostDto createPostDto);

        /// <summary>
        /// Update post from BD.
        /// </summary>
        /// <param name="updatePostDto">
        /// The information about the Post to update.
        /// </param>
        /// <param name="id"></param>
        /// <returns>
        /// Return the post updated.
        /// </returns>
        Task<Post> updatePost(UpdatePostDto updatePostDto, int id);

        /// <summary>
        /// Delete a post from BD.
        /// </summary>
        /// <param name="id">
        /// The id of post searched.
        /// </param>
        /// <returns>
        /// Return the post deleted.
        /// </returns>
        Task<Post> delete(int id);
    }
}
