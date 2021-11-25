using blog_net_core.EF;
using blog_net_core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_net_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private BLOGContext _context;
        public PostsController(BLOGContext context)
        {
            _context = context;
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAll()
        {

            var posts = _context.Posts.ToList();
            return Ok(posts);
        }

        [Route("Get/{postId}")]
        [HttpGet]
        public IActionResult Get(int postId)
        {
            var post = _context.Posts.Find(postId);
            if(post is null)
            {
                return BadRequest("No Data Was Found!");
            }
            return Ok(post);
        }

        [Route("Create")]
        [HttpPost]
        public IActionResult Create(PostModel model)
        {

            Posts post = new Posts();
            post.PostName = model.postName;
            post.PostDescription = model.postDescription;
            post.CreatedAt = DateTime.Today;
            _context.Add(post);
            _context.SaveChanges();

            return Ok(post);
        }

        [Route("Update")]
        [HttpPut]
        public IActionResult Update(PostModel model)
        {
            if (model.postId ==0)
            {
                return BadRequest("No ID Specified.");
            }
            var post = _context.Posts.Find(model.postId);

            if(post is null)
            {
                return BadRequest("Bad ID Specified.");
            }

            post.PostName = model.postName;
            post.PostDescription = model.postDescription;
            post.UpdatedAt = DateTime.Today;
            _context.Attach(post);
            _context.SaveChanges();
            
            return Ok(post);

        }
        
        [Route("DeleteBD/{postId}")]
        [HttpDelete]
        public IActionResult Delete(int postId)
        {
            var post = _context.Posts.Find(postId);
            if (post is null)
            {
                return BadRequest("No Data Was Found!");
            }
            _context.Remove(post);
            _context.SaveChanges();
            
            return Ok(post);
        }

        [Route("SoftDelete")]
        [HttpPut]
        public IActionResult SoftDelete(PostModel model)
        {
            if (model.postId == 0)
            {
                return BadRequest("No ID Specified.");
            }
            var post = _context.Posts.Find(model.postId);

            if (post is null)
            {
                return BadRequest("Bad ID Specified.");
            }

            post.DeletedAt = DateTime.Today;
            _context.Attach(post);
            _context.SaveChanges();

            return Ok(post);

        }

    }
}
