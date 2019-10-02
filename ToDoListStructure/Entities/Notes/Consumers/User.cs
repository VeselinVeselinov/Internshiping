using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities.Notes.Consumers
{
    class User:Persistent
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
