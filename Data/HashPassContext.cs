using HashPass.Models;
using Microsoft.EntityFrameworkCore;

namespace HashPass.Data
{
    public class HashPassContext : DbContext
    {
        public HashPassContext(DbContextOptions<HashPassContext> opt) : base (opt)
        {

        }

        public DbSet<HashPassModel> HashPass { get; set; }
    }
}