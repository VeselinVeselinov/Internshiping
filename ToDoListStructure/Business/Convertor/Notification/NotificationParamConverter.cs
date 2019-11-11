using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.DataAccess.Dao.Alert;
using ToDoListStructure.DataAccess.Dao.Notification;
using ToDoListStructure.DataAccess.Dao.NotificationStatus;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.Notification
{
    class NotificationParamConverter:BaseParamConverter<NotificationParam,Data.Entity.Notification>,INotificationParamConverter
    {
		IAlertDao alertDao = new AlertDao();

		INotificationStatusDao notificationStatusDao = new NotificationStatusDao();

		public override Data.Entity.Notification ConvertSpecific(NotificationParam param, Data.Entity.Notification entity)
		{
			entity.Alert = alertDao.Find(param.AlertId);
			entity.Status = notificationStatusDao.Find(param.StatusId);
			return entity;
		}

		public Data.Entity.Notification Convert(NotificationParam param, Data.Entity.Notification oldEntity)
        {
			Data.Entity.Notification entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Data.Entity.Notification()
				{
					Id=param.Id,
					Code=param.Code
				};
			}

			entity.Name = param.Name;
			entity.Description = param.Description;
			entity.NotificationMessage = param.NotificationMessage;
			ConvertSpecific(param,oldEntity);

			return entity;
		}
	}
}
