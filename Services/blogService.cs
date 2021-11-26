using blog_net_core.EF;
using blog_net_core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_net_core.Services{

    public class blogService : IBlogService{

        private readonly BLOGContext _context;

        public blogService(BLOGContext context){

                _context = context;
        }

            public  List<Posts> getAllPosts(){

                    return _context.Posts.ToList();

            }

            public Posts getPostById(int id){

                    var post = _context.Posts.Find(id); 
                    return post;
                    
            }

            public Posts createPost(PostModel model){

                Posts post = new Posts();
                post.PostName = model.postName;
                post.PostDescription = model.postDescription;
                post.CreatedAt = DateTime.Today;
                _context.Add(post);
                _context.SaveChanges();

                return post;

            }

            public Posts updatePost(PostModel model){

                var post = _context.Posts.Find(model.postId);

                post.PostName = model.postName;
                post.PostDescription = model.postDescription;
                post.UpdatedAt = DateTime.Today;
                _context.Attach(post);
                _context.SaveChanges();

                return post;

            }

            public Posts deleteById(int id){

                var post = _context.Posts.Find(id);
                
                _context.Remove(post);
                _context.SaveChanges();

                return post;

            }

            public Posts softDelete(PostModel model){

            var post = _context.Posts.Find(model.postId);

            post.DeletedAt = DateTime.Today;
            _context.Attach(post);
            _context.SaveChanges();

            return post;
            }

    }


}