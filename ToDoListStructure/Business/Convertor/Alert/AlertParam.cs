using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.Alert
{
    class AlertParam:BaseParamNamed
    {
        public Note Note { get; set; }

        public DateTime TimeReminder { get; set; }

        public Entities.AlertStatus Status { get; set; }
    }
}
