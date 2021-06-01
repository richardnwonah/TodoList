using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Model;

namespace TodoList.TodoData
{
    public class TodoAppContext : DbContext
    {
        public TodoAppContext(DbContextOptions<TodoAppContext> options)
            : base(options)
        {

        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
