using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.NotificationStatus
{
    interface INotificationStatusDao
    {
        ToDoListStructure.Entities.NotificationStatus Save(ToDoListStructure.Entities.NotificationStatus entity);
        List<ToDoListStructure.Entities.NotificationStatus> Save(List<ToDoListStructure.Entities.NotificationStatus> entity);

        ToDoListStructure.Entities.NotificationStatus Update(ToDoListStructure.Entities.NotificationStatus entity);
        List<ToDoListStructure.Entities.NotificationStatus> Update(List<ToDoListStructure.Entities.NotificationStatus> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.NotificationStatus entity);
        void Delete(List<ToDoListStructure.Entities.NotificationStatus> entity);

        ToDoListStructure.Entities.NotificationStatus Find(long id);
        List<ToDoListStructure.Entities.NotificationStatus> Find();
    }
}
