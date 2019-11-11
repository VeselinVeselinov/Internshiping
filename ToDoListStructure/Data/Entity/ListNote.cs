using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Data.Entity
{
    class ListNote:Note
    {
        public List<ListNoteItem> Content { get; set; }
    }
}
