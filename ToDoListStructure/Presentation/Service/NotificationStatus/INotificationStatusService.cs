using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Presentation.Service.NotificationStatus
{
    interface INotificationStatusService
    {
<<<<<<< Updated upstream
=======
        Response FindByPK(long id);

        Response ListAll();

		Response FindByCode(string code);

		Response FindByName(string name);

        Response Create(NotificationStatusParam param);

        Response Create(List<NotificationStatusParam> param);

        Response Update(long id, NotificationStatusParam param);

        Response Update(List<NotificationStatusParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(NotificationStatusParam param);

        void ValidateParameters(List<NotificationStatusParam> param);
>>>>>>> Stashed changes
    }
}
