using Microsoft.EntityFrameworkCore;
using WindowsForm_ofass.Models;

namespace WindowsForm_ofass
{
    public class BookLibraryContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BookLibrary;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }
        public DbSet<LibraryUser> LibraryUsers { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Penalty> Penalties { get; set; }
        public DbSet<BookLanguage> BookLanguages  { get; set; }
        public DbSet<PublishingHouse> PublishingHouses { get; set; }
        public DbSet<ReturnedBook> ReturnedBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
