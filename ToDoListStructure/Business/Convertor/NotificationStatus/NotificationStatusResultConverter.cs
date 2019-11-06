using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.NotificationStatus
{
    class NotificationStatusResultConverter:INotificationStatusResultConverter
    {
<<<<<<< Updated upstream
=======
        public NotificationStatusResult Convert(Entities.NotificationStatus param)
        {
			NotificationStatusResult result = new NotificationStatusResult()
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
