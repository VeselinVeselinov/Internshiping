using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities.Notes
{
    class ListNote:Note
    {
        public List<ListNoteItem> Content { get; set; }
    }
}
