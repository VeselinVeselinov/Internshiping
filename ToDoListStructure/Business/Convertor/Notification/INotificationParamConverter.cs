using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Notification
{
    interface INotificationParamConverter:IBaseParamConverter<NotificationParam,Data.Entity.Notification>
    {
		Data.Entity.Notification Convert(NotificationParam param,Data.Entity.Notification oldEntity);
    }
}
