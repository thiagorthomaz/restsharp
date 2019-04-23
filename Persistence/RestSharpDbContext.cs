using Microsoft.EntityFrameworkCore;
using restsharp.Models;

namespace restsharp.Persistence
{
    public class RestSharpDbContext : DbContext
    {

        public DbSet<Site> Sites { get; set; }

        public DbSet<PostStatus> PostStatus { get; set; }

        public DbSet<Midia> Midias { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PostsCategories> PostsCategories { get; set; }

        public RestSharpDbContext(DbContextOptions<RestSharpDbContext> options) : base(options){

        }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostsCategories>().HasKey(pc => new { pc.PostId, pc.CategoryId });
        }
        
    }
}