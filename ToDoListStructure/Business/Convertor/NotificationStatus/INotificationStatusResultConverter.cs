using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.NotificationStatus
{
    interface INotificationStatusResultConverter
    {
        NotificationStatusResult Convert(ToDoListStructure.Entities.NotificationStatus param);
    }
}
