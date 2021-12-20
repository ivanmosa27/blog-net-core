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
    /// <summary>
    /// This class add methods to transform the different company models into another.
    /// </summary>
    public class PostMappers : Profile
    {
     
        public PostMappers()
        {
            /// <summary>
            /// Mapper CreatePostDto => Post.
            /// </summary>
            /// <typeparam name="CreatePostDto">
            /// Origin Map.
            /// </typeparam>
            /// <typeparam name="Post">
            /// Destination Map.
            /// </typeparam>
            /// <returns>
            /// The post Mapped.
            /// </returns>
            CreateMap<CreatePostDto, Post>();

            /// <summary>
            /// Mapper Post => UpdatePostDto.
            /// </summary>
            /// <typeparam name="UpdatePostDto">
            /// Origin Map.
            /// </typeparam>
            /// <typeparam name="Post">
            /// Destination Map.
            /// </typeparam>
            /// <returns>
            /// The post Mapped.
            /// </returns>
            CreateMap<UpdatePostDto, Post>();
            
        }   
    }
}
