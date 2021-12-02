using blog_net_core.Project.Modules.Model.Entities.Posts;
using blog_net_core.Project.Modules.Model.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_net_core.Project.Modules.Services{

    public class postService : IPostService{

        private readonly PostContext _context;

        public postService(PostContext context){

                _context = context;
        }

            public  List<Post> getAllPosts(){

                    return _context.Posts.ToList();
                    

            }

            public Post getPostById(int id){

                    var post = _context.Posts.Find(id); 
                    return post;
                    
            }

            public Post createPost(PostModel model){

                Post post = new Post();
                post.PostName = model.postName;
                post.PostDescription = model.postDescription;
                post.CreatedAt = DateTime.Today;
                _context.Add(post);
                _context.SaveChanges();

                return post;

            }

            public Post updatePost(PostModel model){

                var post = _context.Posts.Find(model.postId);

                post.PostName = model.postName;
                post.PostDescription = model.postDescription;
                post.UpdatedAt = DateTime.Today;
                _context.Attach(post);
                _context.SaveChanges();

                return post;

            }

            public Post deleteById(int id){

                var post = _context.Posts.Find(id);
                
                _context.Remove(post);
                _context.SaveChanges();

                return post;

            }

            public Post softDelete(PostModel model){

            var post = _context.Posts.Find(model.postId);

            post.DeletedAt = DateTime.Today;
            _context.Attach(post);
            _context.SaveChanges();

            return post;
            }

    }


}