using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities.Notes
{
    class ListNoteItem : NamedPersistent
    {
        public bool IsChecked { get; set; }

        public string Text { get; set; }
    }
}
