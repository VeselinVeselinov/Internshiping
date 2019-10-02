using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities.Notes
{
    class ListNoteItem:NamedPersistent
    {
        public bool Checked { get; set; }
        public string ItemText { get; set; }
    }
}
