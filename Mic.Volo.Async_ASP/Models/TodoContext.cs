using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mic.Volo.Async_ASP.Models
{
    public class TodoContext:DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }
    }
}