using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.NotificationStatus
{
    interface INotificationStatusParamConverter
    {
        ToDoListStructure.Entities.NotificationStatus Convert(NotificationStatusParam param);
    }
}
