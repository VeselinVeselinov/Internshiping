using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities.Notes.Consumers
{
    class Account:NamedPersistent
    {
        public List<Note> UserNotes { get; set; }
        public User AccountUser { get; set; }
    }
}
