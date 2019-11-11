using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.DataAccess.Dao.NotificationStatus;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.NotificationStatus
{
    class NotificationStatusParamConverter:BaseParamConverter<NotificationStatusParam,Data.Entity.NotificationStatus>,INotificationStatusParamConverter
    {
		public override Data.Entity.NotificationStatus ConvertSpecific(NotificationStatusParam param, Data.Entity.NotificationStatus entity)
		{
			throw new NotImplementedException();
		}

		public Data.Entity.NotificationStatus Convert(NotificationStatusParam param, Data.Entity.NotificationStatus oldEntity)
        {
			Data.Entity.NotificationStatus entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Data.Entity.NotificationStatus()
				{
					Id=param.Id,
					Code=param.Code
				};
			}

			entity.Name = param.Name;
			entity.Description = param.Description;

			return entity;
		}
	}
}
