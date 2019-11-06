using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Notification
{
    class NotificationParamConverter:INotificationParamConverter
    {
<<<<<<< Updated upstream
    }
=======
		public INotificationDao Dao = new NotificationDao();

		public Entities.Notification Convert(NotificationParam param)
		{
			Entities.Notification entity = new Entities.Notification()
			{
				Id = param.Id,
				Code = param.Code,
				Name = param.Name,
				Description = param.Description,
				Alert=param.Alert,
				NotificationMessage=param.NotificationMessage,
				Status=param.Status
			};
			return entity;
		}

		public Entities.Notification Convert(NotificationParam param, Entities.Notification oldEntity)
		{
			Entities.Notification entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Entities.Notification();
			}

			entity.Name = param.Name;
			entity.Description = param.Description;
			entity.Alert = param.Alert;
			entity.NotificationMessage = param.NotificationMessage;
			entity.Status = param.Status;

			return entity;
		}
	}
>>>>>>> Stashed changes
}
