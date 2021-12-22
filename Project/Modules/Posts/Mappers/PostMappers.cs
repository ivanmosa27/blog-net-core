using System;
using System.Collections.Generic;
using blog_net_core.Project.Modules.Posts.Model.Entities;
using blog_net_core.Project.Modules.Shared.Extensions;
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
    public static class PostMappers
    {
        public static Post MergeWithUpdatePost(
            this Post @this,
            UpdatePostDto updatePostDto
        )
        {
            var model = new Post()
            {
                
                PostName = updatePostDto.PostName ?? @this.PostName,
                PostDescription = updatePostDto.PostDescription ?? @this.PostDescription,

                // Immutable fields:
                PostId = @this.PostId
            
            };
            @this.MergeEntityWith(model);
            return @this;
        }
    }
}
