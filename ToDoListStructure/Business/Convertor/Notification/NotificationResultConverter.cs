using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Notification
{
    class NotificationResultConverter:INotificationResultConverter
    {
<<<<<<< Updated upstream
=======
        public NotificationResult Convert(Entities.Notification param)
        {
			NotificationResult result = new NotificationResult()
			{
				Id = param.Id,
				Code = param.Code,
				Name = param.Name,
				Description = param.Description,
			};
			return result;
		}
>>>>>>> Stashed changes
    }
}
