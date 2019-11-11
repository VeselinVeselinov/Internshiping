using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.NotificationStatus
{
    class NotificationStatusResultConverter : BaseResultConverter<Data.Entity.NotificationStatus,NotificationStatusResult>,INotificationStatusResultConverter
    {
		public override NotificationStatusResult ConvertSpecific(Data.Entity.NotificationStatus entity, NotificationStatusResult result)
		{
			throw new NotImplementedException();
		}

		public NotificationStatusResult Convert(Data.Entity.NotificationStatus param)
        {
			NotificationStatusResult result = ConvertStandart(param, new NotificationStatusResult());
			return result;
        }
	}
}
