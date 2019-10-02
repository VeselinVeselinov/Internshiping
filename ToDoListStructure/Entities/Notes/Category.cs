using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities.Notes
{
    class Category:NamedPersistent
    {
        public List<Note> CategoryMembers { get; set; }
    }
}
