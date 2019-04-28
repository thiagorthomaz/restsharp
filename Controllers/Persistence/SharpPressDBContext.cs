using Microsoft.EntityFrameworkCore;
using sharppress.Models;

namespace sharppress.Controllers.Persistence
{

    public class SharpPressDBContext : DbContext
    {

        public DbSet<Site> Sites { get; set; }

        public DbSet<PostStatus> PostStatus { get; set; }

        public DbSet<Midia> Midias { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PostCategory> PostsCategories { get; set; }
        
        public SharpPressDBContext(DbContextOptions<SharpPressDBContext> options) : base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostCategory>().HasKey(pc => new { pc.PostId, pc.CategoryId });
        }

    }
}