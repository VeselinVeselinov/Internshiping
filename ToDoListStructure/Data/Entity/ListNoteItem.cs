using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Data.Entity
{
    class ListNoteItem:PersistentNamed
    {
        public bool IsChecked { get; set; }

        public string Text { get; set; }
    }
}
