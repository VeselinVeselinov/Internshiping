using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Notification
{
    interface INotificationDao
    {
<<<<<<< Updated upstream:ToDoListStructure/DataAccess/Dao/Notification/INotificationDeo.cs
=======
        ToDoListStructure.Entities.Notification Save(ToDoListStructure.Entities.Notification entity);
        List<ToDoListStructure.Entities.Notification> Save(List<ToDoListStructure.Entities.Notification> entity);

        ToDoListStructure.Entities.Notification Update(ToDoListStructure.Entities.Notification entity);
        List<ToDoListStructure.Entities.Notification> Update(List<ToDoListStructure.Entities.Notification> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.Notification entity);
        void Delete(List<long> ids);

        ToDoListStructure.Entities.Notification Find(long id);
        List<ToDoListStructure.Entities.Notification> Find();
		Entities.Notification FindByCode(string name);
		List<Entities.Notification> FindByName(string name);

>>>>>>> Stashed changes:ToDoListStructure/DataAccess/Dao/Notification/INotificationDao.cs
    }
}
