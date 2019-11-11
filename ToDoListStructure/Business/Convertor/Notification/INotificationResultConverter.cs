using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Notification
{
    interface INotificationResultConverter:IBaseResultConverter<Data.Entity.Notification,NotificationResult>
    {
        NotificationResult Convert(ToDoListStructure.Data.Entity.Notification param);
    }
}
