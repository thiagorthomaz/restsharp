using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using restsharp.Models;
using restsharp.Persistence;

namespace restsharp.Controllers
{

    [Route("/api/posts")]
    public class PostsController : Controller
    {
        private readonly RestSharpDbContext context;

        public PostsController(RestSharpDbContext context)
        {
            this.context = context;


        }

        [HttpGet("categories")]
        public async Task<IEnumerable<Category>> categories()
        {

            var categories = await context.Categories.Where(c => c.DeletedAt == null).ToListAsync();
            return categories;

        }

        [HttpGet("status")]
        public async Task<IEnumerable<PostStatus>> status()
        {
            var postStatus = await context.PostStatus.ToListAsync();
            return postStatus;
        }

        [HttpGet("bySite/{id}")]
        public async Task<IEnumerable<Post>> bySite(int id)
        {
            var posts = await context.Posts.Where(p => p.SiteId == id).ToListAsync();
            return posts;
        }

    }
}