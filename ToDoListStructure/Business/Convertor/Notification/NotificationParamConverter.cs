using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.Notification;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.Notification
{
    class NotificationParamConverter:INotificationParamConverter
    {
        public INotificationDao Dao { get; set; }

        public Entities.Notification Convert(NotificationParam param)
        {
            throw new NotImplementedException();
        }
    }
}
