using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Entities.Notes;

namespace ToDoListStructure.Entities.Actions
{
    class Alert:NamedPersistent
    {
        public Note Note { get; set; }

        public DateTime TimeReminder { get; set; }

        public Status Status { get; set; }
    }
}
