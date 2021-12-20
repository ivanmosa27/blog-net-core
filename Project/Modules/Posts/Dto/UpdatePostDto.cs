using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace blog_net_core.Project.Modules.Posts.Dto
{
    /// <summary>
    /// DTO to update a post.
    /// </summary>
    public class UpdatePostDto
    {
        /// <summary>
        /// The postName field.
        /// </summary>
        public string PostName { get; set; }

        /// <summary>
        /// The postDescription field. 
        /// </summary>
        public string PostDescription { get; set; }
    }
}
