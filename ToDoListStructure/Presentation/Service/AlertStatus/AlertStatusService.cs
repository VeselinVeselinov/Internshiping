using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.AlertStatus;

namespace ToDoListStructure.Presentation.Service.AlertStatus
{
    class AlertStatusService:IAlertStatusService
    {
        public AlertStatusProcessor Processor { get; set; }
    }
}
