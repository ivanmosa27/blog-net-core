using System;
using System.Collections.Generic;
using blog_net_core.Project.Modules.Posts.Model.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace blog_net_core.Project.Modules.Blogs.Model.Entities
{
    /// <summary>
    /// A static class that contains the db specifications fields of the blog entity.
    /// </summary>
    public partial class Blog
    {
        /// <summary>
        /// Identifier from Blog.
        /// </summary>
        public int BlogId { get; set; }

        /// <summary>
        /// Blog name.
        /// </summary>
        public string BlogName { get; set; }

        /// <summary>
        /// The post Id related to the blog
        /// </summary>
        public int postId {get; set;}

        /// <summary>
        /// Creation date.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Post modification date.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Date od deletion.
        /// </summary>
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Post to which a blog belongs
        /// </summary>
        public Post post {get; set;}
    }
}
