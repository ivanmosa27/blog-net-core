using System;
using System.Collections.Generic;
using blog_net_core.Project.Modules.Blogs.Model.Entities;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace blog_net_core.Project.Modules.Posts.Model.Entities
{
    /// <summary>
    /// A static class that contains the db specifications fields of the post entity.
    /// </summary>
    public partial class Post
    {
        /// <summary>
        ///  Identifier from Post.
        /// </summary>
        public int PostId { get; set; }

        /// <summary>
        /// Post name.
        /// </summary>
        public string PostName { get; set; }

        /// <summary>
        /// Post description.
        /// </summary>
        public string PostDescription { get; set; }

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
        /// Blog to which a post belongs
        /// </summary>
        public List<Blog> blogs {get;set;}
    }
}
