using Microsoft.EntityFrameworkCore;
using ToDoList.Web.Models;

namespace ToDoList.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        
        public ApplicationDbContext(DbContextOptions options):
            base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>().HasKey(t => t.Id);
            modelBuilder.Entity<Task>().Property(t => t.TaskName).IsRequired().HasMaxLength(256);
            modelBuilder.Entity<Task>().Property(t => t.Done).IsRequired().HasDefaultValue(false);
        }
    }
}