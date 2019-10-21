using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.NotificationStatus;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.NotificationStatus
{
    class NotificationStatusParamConverter:INotificationStatusParamConverter
    {
        public INotificationStatusDao Dao { get; set; }

        public Entities.NotificationStatus Convert(NotificationStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
