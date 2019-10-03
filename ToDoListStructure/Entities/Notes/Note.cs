using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ToDoListStructure.Entities.Consumers;

namespace ToDoListStructure.Entities.Notes
{
    abstract class Note:NamedPersistent
    {
        public Color Color { get; set; }

        public Account Account { get; set; }

        public Category Category { get; set; }

        public Status Status { get; set; }

        public int TextSize { get; set; }
    }
}
