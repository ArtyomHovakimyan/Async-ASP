using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mic.Volo.Async_ASP.Models
{
    public class ToDo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
    public class TodoDbInitializer : DropCreateDatabaseAlways<TodoContext>
    {
        protected override void Seed(TodoContext db)
        {
            db.ToDos.Add(new ToDo { ID=1,Title="read book",Completed=false });
            db.ToDos.Add(new ToDo { ID = 2, Title = "read book", Completed = false });
            db.ToDos.Add(new ToDo { ID = 3, Title = "read book", Completed = false });

            base.Seed(db);
        }
    }
}