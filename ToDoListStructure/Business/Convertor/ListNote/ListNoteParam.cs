using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ListNote
{
    class ListNoteParam:BaseParamNamed
    {
        public List<Entities.ListNoteItem> Content { get; set; }

        public Color Color { get; set; }

        public Entities.Account Account { get; set; }

        public Entities.Category Category { get; set; }

        public Entities.NoteStatus Status { get; set; }

        public int TextSize { get; set; }
    }
}
