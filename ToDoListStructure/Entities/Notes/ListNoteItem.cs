using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities.Notes
{
    class ListNoteItem:NamedPersistent
    {
        public Status Status { get; set; }

        public string Text { get; set; }
    }
}
