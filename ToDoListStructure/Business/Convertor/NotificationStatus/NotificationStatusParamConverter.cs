using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.NotificationStatus
{
    class NotificationStatusParamConverter:INotificationStatusParamConverter
    {
<<<<<<< Updated upstream
    }
=======
		public INotificationStatusDao Dao = new NotificationStatusDao();

        public Entities.NotificationStatus Convert(NotificationStatusParam param)
        {
			Entities.NotificationStatus entity = new Entities.NotificationStatus()
			{
				Id = param.Id,
				Code = param.Code,
				Name = param.Name,
				Description = param.Description,
			};
			return entity;
		}

		public Entities.NotificationStatus Convert(NotificationStatusParam param, Entities.NotificationStatus oldEntity)
		{
			Entities.NotificationStatus entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Entities.NotificationStatus();
			}

			entity.Name = param.Name;
			entity.Description = param.Description;

			return entity;
		}
	}
>>>>>>> Stashed changes
}
