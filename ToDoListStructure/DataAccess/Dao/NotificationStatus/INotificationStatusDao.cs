using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.NotificationStatus
{
    interface INotificationStatusDao
    {
		ToDoListStructure.Data.Entity.NotificationStatus Save(ToDoListStructure.Data.Entity.NotificationStatus entity);
		List<ToDoListStructure.Data.Entity.NotificationStatus> Save(List<ToDoListStructure.Data.Entity.NotificationStatus> entity);

		ToDoListStructure.Data.Entity.NotificationStatus Update(ToDoListStructure.Data.Entity.NotificationStatus entity);
		List<ToDoListStructure.Data.Entity.NotificationStatus> Update(List<ToDoListStructure.Data.Entity.NotificationStatus> entity);

		void Delete(long id);
		void Delete(ToDoListStructure.Data.Entity.NotificationStatus entity);
		void Delete(List<long> ids);

		ToDoListStructure.Data.Entity.NotificationStatus Find(long id);
		List<ToDoListStructure.Data.Entity.NotificationStatus> Find();
		Data.Entity.NotificationStatus FindByCode(string code);
		List<Data.Entity.NotificationStatus> FindByName(string name);
		List<Data.Entity.NotificationStatus> FindByAttribute(string att, string value);
	}
}
