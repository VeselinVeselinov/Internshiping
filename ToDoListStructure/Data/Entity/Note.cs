using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Data.Entity
{
    abstract class Note:PersistentNamed
    {
        public Color Color { get; set; }

        public AccountStatus Account { get; set; }

        public Category Category { get; set; }

        public NoteStatus Status { get; set; }

        public int TextSize { get; set; }
    }
}
