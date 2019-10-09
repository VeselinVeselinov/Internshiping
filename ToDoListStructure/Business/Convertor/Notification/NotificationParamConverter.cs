using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.Notification;

namespace ToDoListStructure.Business.Convertor.Notification
{
    class NotificationParamConverter:INotificationParamConverter
    {
        public NotificationDao Dao { get; set; }
    }
}
