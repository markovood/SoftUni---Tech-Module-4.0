namespace ToDoList.Data
{
    using Microsoft.EntityFrameworkCore;
    using ToDoList.Models;

    public class ToDoDbContext : DbContext
    {
        private const string CONNECTION_STRING = @"Server=.\SQLEXPRESS;DataBase=ToDoDb;Integrated Security=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
