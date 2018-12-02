namespace Library.Data
{
    using Library.Models;
    using Microsoft.EntityFrameworkCore;
    
    public class LibraryDbContext : DbContext
    {
        private const string CONNECTION_STRING = @"Server=.\SQLEXPRESS;Database=LibraryDB;Integrated Security=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }

        public DbSet<Book> Books { get; set; }
    }
}
