using Microsoft.EntityFrameworkCore;
using restsharp.Models;

namespace restsharp.Persistence
{
    public class RestSharpDbContext : DbContext
    {

        public DbSet<Site> Sites { get; set; }

        public RestSharpDbContext(DbContextOptions<RestSharpDbContext> options) : base(options){

        }   
    }
}