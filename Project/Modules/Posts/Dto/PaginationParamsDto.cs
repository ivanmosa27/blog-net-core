using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace blog_net_core.Project.Modules.Posts.Dto
{
    public class PaginationParamsDto
    {

       public int PerPage {get;set;}
       public int currentPage {get;set;}

       public PaginationParamsDto()
       {

           this.PerPage = 1;
           this.currentPage = 1;

       }

       public PaginationParamsDto(int PerPage, int currentPage)
       {
           this.PerPage = PerPage > 5 ? 5 : PerPage;
           this.currentPage = currentPage < 1 ? 1 : currentPage;
       }
    }
}
