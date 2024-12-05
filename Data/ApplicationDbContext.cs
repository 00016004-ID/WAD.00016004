using BookCatalogApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WAD._00016004.Data//00016004
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }//00016004
}

