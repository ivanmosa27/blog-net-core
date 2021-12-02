using System;
using blog_net_core.Project.Modules.Model.Entities.Posts;
using blog_net_core.Project.Modules.Model.Entities.Blogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace blog_net_core.Project.Modules.Model.Entities.Posts
{
    public partial class PostContext : DbContext
    {
        public PostContext()
        {
        }

        public PostContext(DbContextOptions<PostContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Blog> blogs {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=LocalDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.PostId);

                entity.ToTable("POSTS");

                entity.Property(e => e.PostId).HasColumnName("postId");

                entity.Property(e => e.CreatedAt).HasColumnName("createdAt");

                entity.Property(e => e.DeletedAt).HasColumnName("deletedAt");

                entity.Property(e => e.PostDescription).HasColumnName("postDescription");

                entity.Property(e => e.PostName).HasColumnName("postName");

                entity.Property(e => e.UpdatedAt).HasColumnName("updatedAt");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
