using System;
using System.Collections.Generic;
using blog_net_core.Project.Modules.Posts.Model.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace blog_net_core.Project.Modules.Blogs.Model.Entities

{
    public partial class Blog
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public int postId {get; set;}
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Post post {get; set;}
    }
}
