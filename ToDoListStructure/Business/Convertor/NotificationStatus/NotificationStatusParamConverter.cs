using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.NotificationStatus;

namespace ToDoListStructure.Business.Convertor.NotificationStatus
{
    class NotificationStatusParamConverter:INotificationStatusParamConverter
    {
        public NotificationStatusDao Dao { get; set; }
    }
}
