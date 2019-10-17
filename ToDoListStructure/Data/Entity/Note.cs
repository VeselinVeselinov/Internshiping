using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace ToDoListStructure.Entities
{
    abstract class Note:NamedPersistent
    {
        public Color Color { get; set; }

        public Account Account { get; set; }

        public Category Category { get; set; }

        public NoteStatus Status { get; set; }

        public int TextSize { get; set; }
    }
}
