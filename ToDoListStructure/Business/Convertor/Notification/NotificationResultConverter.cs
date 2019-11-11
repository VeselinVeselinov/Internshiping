using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.Notification
{
    class NotificationResultConverter : BaseResultConverter<Data.Entity.Notification,NotificationResult>,INotificationResultConverter
    {
		public override NotificationResult ConvertSpecific(Data.Entity.Notification entity, NotificationResult result)
		{
			result.AlertId = entity.Alert.Id;
			result.AlertName = entity.Alert.Name;
			result.StatusId = entity.Status.Id;
			result.StatusName = entity.Name;
			return result;
		}

		public NotificationResult Convert(Data.Entity.Notification param)
        {
			NotificationResult result = ConvertStandart(param, new NotificationResult());
			return ConvertSpecific(param,result);
        }
	}
}
