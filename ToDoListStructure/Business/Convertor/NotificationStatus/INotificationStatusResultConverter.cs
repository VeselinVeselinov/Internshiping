using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.NotificationStatus
{
    interface INotificationStatusResultConverter:IBaseResultConverter<Data.Entity.NotificationStatus,NotificationStatusResult>
    {
        NotificationStatusResult Convert(ToDoListStructure.Data.Entity.NotificationStatus param);
    }
}
