using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Notification
{
    interface INotificationDao
    {
		ToDoListStructure.Data.Entity.Notification Save(ToDoListStructure.Data.Entity.Notification entity);
		List<ToDoListStructure.Data.Entity.Notification> Save(List<ToDoListStructure.Data.Entity.Notification> entity);

		ToDoListStructure.Data.Entity.Notification Update(ToDoListStructure.Data.Entity.Notification entity);
		List<ToDoListStructure.Data.Entity.Notification> Update(List<ToDoListStructure.Data.Entity.Notification> entity);

		void Delete(long id);
		void Delete(ToDoListStructure.Data.Entity.Notification entity);
		void Delete(List<long> ids);

		ToDoListStructure.Data.Entity.Notification Find(long id);
		List<ToDoListStructure.Data.Entity.Notification> Find();
		Data.Entity.Notification FindByCode(string name);
		List<Data.Entity.Notification> FindByName(string name);
		List<Data.Entity.Notification> FindByAttribute(string att, string value);
	}
}
