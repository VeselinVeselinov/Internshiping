using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities
{
    class Alert:NamedPersistent
    {
        public Note Note { get; set; }

        public DateTime TimeReminder { get; set; }

        public AlertStatus Status { get; set; }
    }
}
