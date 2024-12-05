using BookCatalogApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WAD._00016004.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}

