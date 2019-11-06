\using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Notification
{
    interface INotificationParamConverter
    {
<<<<<<< Updated upstream
=======
        ToDoListStructure.Entities.Notification Convert(NotificationParam param);

		Entities.Notification Convert(NotificationParam param, Entities.Notification oldEntity);
>>>>>>> Stashed changes
    }
}
