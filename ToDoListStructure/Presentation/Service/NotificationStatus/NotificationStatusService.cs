using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.NotificationStatus;

namespace ToDoListStructure.Presentation.Service.NotificationStatus
{
    class NotificationStatusService:INotificationStatusService
    {
        public NotificationStatusProcessor Processor { get; set; }
    }
}
