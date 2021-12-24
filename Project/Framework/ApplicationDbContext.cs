using System;
using blog_net_core.Project.Modules.Posts.Model.Entities;
using blog_net_core.Project.Modules.Blogs.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace blog_net_core.Project.Framework
{
    public partial class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Blog> Blogs {get;set;}

    }
}
