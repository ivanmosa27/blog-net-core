using blog_net_core.Project.Modules.Blogs.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_net_core.Project.Modules.Blogs.Services{

    public class blogService : IBlogService{

      private readonly ApplicationDbContext _dbContext;

        public blogService(ApplicationDbContext dbContext){

                _dbContext = dbContext;
        }

            public async Task<Blog> getBlogById(int id){

                var blog = await _dbContext.blogs.Include(x => x.post).FirstOrDefaultAsync(x => x.BlogId == id);
                return blog;
            }

            public async Task<String> createBlog(Blog blog){

                var existsPost = await _dbContext.Posts.AnyAsync(x => x.PostId == blog.postId);
                
                if(!existsPost){
                    return($"The post with ID: {blog.postId}, doesn't exist.");
                }
                _dbContext.Add(blog);
                blog.CreatedAt = DateTime.Today;
                await _dbContext.SaveChangesAsync();
                return("Blog created succefully!");                
            }

    }


}