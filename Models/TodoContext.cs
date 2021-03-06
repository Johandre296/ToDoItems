using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ToDoMVCtutorial.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext()
        {

        }

        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }


        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
