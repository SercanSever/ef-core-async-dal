using AsyncProgramming.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace AsyncProgramming.Data.Context
{
    public class AsyncProgrammingContext : DbContext
    {
        public AsyncProgrammingContext()
        {

        }
        public AsyncProgrammingContext(DbContextOptions<AsyncProgrammingContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
