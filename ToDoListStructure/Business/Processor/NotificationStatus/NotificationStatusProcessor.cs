using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.NotificationStatus;
using ToDoListStructure.DataAccess.Dao.NotificationStatus;

namespace ToDoListStructure.Business.Processor.NotificationStatus
{
    class NotificationStatusProcessor:INotificationStatusProcessor
    {
        public NotificationStatusDao Dao { get; set; }

        public NotificationStatusParamConverter ParamConverter { get; set; }

        public NotificationStatusResultConverter ResultConverter { get; set; }
    }
}
