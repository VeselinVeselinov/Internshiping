using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Data.Entity
{
    class Alert:PersistentNamed
    {
        public Note Note { get; set; }

        public DateTime TimeReminder { get; set; }

        public AlertStatus Status { get; set; }
    }
}
