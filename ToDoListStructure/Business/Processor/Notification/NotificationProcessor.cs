using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Notification;
using ToDoListStructure.DataAccess.Dao.Notification;

namespace ToDoListStructure.Business.Processor.Notification
{
    class NotificationProcessor:INotificationProcessor
    {
        public NotificationDao Dao { get; set; }

        public NotificationParamConverter ParamConverter { get; set; }

        public NotificationResultConverter ResultConverter { get; set; }
    }
}
