using System;
using System.Collections.Generic;
using blog_net_core.Project.Modules.Posts.Model.Entities;
using blog_net_core.Project.Modules.Posts.Dto;
using System.ComponentModel.DataAnnotations;
using AutoMapper;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace blog_net_core.Project.Modules.Posts.Mappers
{
    public class PostMappers : Profile
    {
        public PostMappers()
        {
            CreateMap<CreatePostDto, Post>();
        }   
    }
}
