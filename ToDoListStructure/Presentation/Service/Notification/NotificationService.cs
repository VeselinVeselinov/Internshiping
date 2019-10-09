using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.Notification;

namespace ToDoListStructure.Presentation.Service.Notification
{
    class NotificationService:INotificationService
    {
        public NotificationProcessor Processor { get; set; }
    }
}
