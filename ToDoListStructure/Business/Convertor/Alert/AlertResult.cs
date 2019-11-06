using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Alert
{
    class AlertResult:BaseResultNamed
    {
        public Entities.Note Note { get; set; }

        public DateTime TimeReminder { get; set; }

        public Entities.AlertStatus Status { get; set; }
    }
}
