using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sharppress.Controllers.Persistence;
using sharppress.Controllers.Resources;
using sharppress.Models;

namespace sharppress.Controllers
{

    [Route("/api/posts")]
    public class PostsController : Controller
    {
        private readonly SharpPressDBContext context;
        private readonly IMapper mapper;

        public PostsController(SharpPressDBContext context, IMapper mapper)
        {
            this.mapper = mapper;
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

        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {

            var post = await context.Posts.Include(p => p.Categories).FirstAsync();
            var postResource = mapper.Map<Post, PostResource>(post);

            return Ok(postResource);

        }

        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody]PostResource postResource)
        {

            var newPost = mapper.Map<PostResource, Post>(postResource);
            newPost.CreatedAt = DateTime.Now;
            context.Posts.Add(newPost);
            await context.SaveChangesAsync();

            var postSaved = mapper.Map<Post, PostResource>(newPost);
            return Ok(postSaved);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePost(int id, [FromBody]PostResource postResource)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var post = await context.Posts.Include(p => p.Categories).SingleOrDefaultAsync(p => p.Id == id);

            if (post == null)
                return NotFound();

            mapper.Map<PostResource, Post>(postResource, post);
            post.UpdatedAt = DateTime.Now;

            await context.SaveChangesAsync();

            var postSaved = mapper.Map<Post, PostResource>(post);
            return Ok(postSaved);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {

            var post = await context.Posts.SingleOrDefaultAsync(p => p.Id == id);

            if (post == null)
                return NotFound();

            post.DeletedAt = DateTime.Now;
            await context.SaveChangesAsync();
            var postDeleted = mapper.Map<Post, PostResource>(post);
            
            return Ok(postDeleted);

        }


    }
}