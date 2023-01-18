using Microsoft.EntityFrameworkCore;
using ToDoListDDD.Domain.Entities;

namespace ToDoListDDD.Infrastructure
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
        }
    }
}