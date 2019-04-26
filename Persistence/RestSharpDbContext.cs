using Microsoft.EntityFrameworkCore;
using sharppress.Models;

namespace sharppress.Persistence
{
    public class sharppressDbContext : DbContext
    {

        public DbSet<Site> Sites { get; set; }

        public DbSet<PostStatus> PostStatus { get; set; }

        public DbSet<Midia> Midias { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PostsCategories> PostsCategories { get; set; }

        public sharppressDbContext(DbContextOptions<sharppressDbContext> options) : base(options){

        }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostsCategories>().HasKey(pc => new { pc.PostId, pc.CategoryId });
        }
        
    }
}