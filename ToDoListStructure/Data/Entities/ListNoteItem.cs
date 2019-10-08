using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities
{
    class ListNoteItem:NamedPersistent
    {
        public bool Checked { get; set; }

        public string Text { get; set; }
    }
}
