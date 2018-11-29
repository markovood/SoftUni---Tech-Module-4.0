namespace TeisterMask.Data
{
    using Microsoft.EntityFrameworkCore;
    using TeisterMask.Models;

    public class TeisterMaskDbContext : DbContext
    {
        private const string CONNECTION_STRING = @"Server=.\SQLEXPRESS;Database=TeisterMaskDb;Integrated Security=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
