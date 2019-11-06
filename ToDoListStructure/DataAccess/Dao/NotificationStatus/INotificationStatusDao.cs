using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.NotificationStatus
{
    interface INotificationStatusDao
    {
<<<<<<< Updated upstream
=======
        ToDoListStructure.Entities.NotificationStatus Save(ToDoListStructure.Entities.NotificationStatus entity);
        List<ToDoListStructure.Entities.NotificationStatus> Save(List<ToDoListStructure.Entities.NotificationStatus> entity);

        ToDoListStructure.Entities.NotificationStatus Update(ToDoListStructure.Entities.NotificationStatus entity);
        List<ToDoListStructure.Entities.NotificationStatus> Update(List<ToDoListStructure.Entities.NotificationStatus> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.NotificationStatus entity);
        void Delete(List<long> ids);

        ToDoListStructure.Entities.NotificationStatus Find(long id);
        List<ToDoListStructure.Entities.NotificationStatus> Find();
		Entities.NotificationStatus FindByCode(string code);
		List<Entities.NotificationStatus> FindByName(string name);
>>>>>>> Stashed changes
    }
}
