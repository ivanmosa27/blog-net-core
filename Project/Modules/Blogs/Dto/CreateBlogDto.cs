using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace blog_net_core.Project.Modules.Blogs.Dto
{
    /// <summary>
    /// DTO to create a Post.
    /// </summary>
    public class CreateBlogDto
    {
        /// <summary>
        /// The postName field. This field are required.
        /// </summary>
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string postName { get; set; }

        /// <summary>
        /// The postDescription field.
        /// </summary>
        public string postDescription { get; set; }
    }
}
