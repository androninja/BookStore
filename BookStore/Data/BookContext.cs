using Microsoft.EntityFrameworkCore;
using BookStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BookStore.Data
{
    public class BookContext:IdentityDbContext
    {

        public BookContext(DbContextOptions<BookContext> options) : base(options) { }   
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "SQL",
                    Author = "Agrim",
                    Description = "Complete guide to SQL and Relational Databases",
                    Language = Language.Spanish
                },
                new Book
                {
                    Id = 2,
                    Title = "Dot Net",
                    Author = "Agrim",
                    Description = "Complete guide to Dot Net and C#",
                    Language = Language.English
                }
            );
        }
    }
}
