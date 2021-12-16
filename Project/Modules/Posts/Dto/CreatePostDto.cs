﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace blog_net_core.Project.Modules.Posts.Dto
{
    public class CreatePostDto
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string postName { get; set; }
        public string postDescription { get; set; }
    }
}
