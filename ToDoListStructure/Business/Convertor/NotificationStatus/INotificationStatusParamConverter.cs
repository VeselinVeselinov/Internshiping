using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.NotificationStatus
{
    interface INotificationStatusParamConverter:IBaseParamConverter<NotificationStatusParam,Data.Entity.NotificationStatus>
    {
		Data.Entity.NotificationStatus Convert(NotificationStatusParam param, Data.Entity.NotificationStatus oldEntity);
    }
}
