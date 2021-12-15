using System;
using System.Collections.Generic;
using blog_net_core.Project.Modules.Blogs.Model.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace blog_net_core.Project.Modules.Posts.Model.Entities
{
    public partial class Post
    {
        public int PostId { get; set; }
        public string PostName { get; set; }
        public string PostDescription { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public List<Blog> blogs {get;set;}
    }
}
