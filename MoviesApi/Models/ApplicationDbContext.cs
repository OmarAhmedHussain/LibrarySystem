using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;

namespace MoviesApi.Models
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Patron> Patrons { get; set; }

        public DbSet<BorrowingRecord> BorrowingRecords { get; set;}

    }
}
