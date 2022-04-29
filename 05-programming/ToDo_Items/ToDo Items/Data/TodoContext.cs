using Microsoft.EntityFrameworkCore;
using ToDo_Items.Models;

namespace ToDo_Items.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)

        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
