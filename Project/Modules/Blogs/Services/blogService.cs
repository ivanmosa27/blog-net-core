using blog_net_core.Project.Modules.Blogs.Model.Entities;
using blog_net_core.Project.Framework;
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
            /// <inheritdoc > Implemented using the blog service interface.</inheritdoc>
            public async Task<Blog> getBlogById(int id){

                var blog = await _dbContext.Blogs.Include(x => x.post).FirstOrDefaultAsync(x => x.BlogId == id);
                return blog;
            }
            /// <inheritdoc > Implemented using the blog service interface.</inheritdoc>
            public async Task<Blog> createBlog(Blog blog){

                var existsPost = await _dbContext.Posts.AnyAsync(x => x.PostId == blog.postId);
                
                if(!existsPost){
                   
                }
                _dbContext.Add(blog);
                blog.CreatedAt = DateTime.Today;
                await _dbContext.SaveChangesAsync();
                return blog;                
            }

    }


}