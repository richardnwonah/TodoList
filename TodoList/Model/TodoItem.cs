using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Model
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int IsComplete { get; set; }
        public DateTime date { get; set; }
    }
}
