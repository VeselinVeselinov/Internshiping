using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.Alert;

namespace ToDoListStructure.Presentation.Service.Alert
{
    class AlertService:IAlertService
    {
        public AlertProcessor Processor { get; set; }
    }
}
