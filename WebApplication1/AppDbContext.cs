using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BookAPI
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Book> Books { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
