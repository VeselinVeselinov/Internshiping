using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Alert
{
    interface IAlertDao
    {
		ToDoListStructure.Data.Entity.Alert Save(ToDoListStructure.Data.Entity.Alert entity);
		List<ToDoListStructure.Data.Entity.Alert> Save(List<ToDoListStructure.Data.Entity.Alert> entity);

		ToDoListStructure.Data.Entity.Alert Update(ToDoListStructure.Data.Entity.Alert entity);
		List<ToDoListStructure.Data.Entity.Alert> Update(List<ToDoListStructure.Data.Entity.Alert> entity);

		void Delete(long id);
		void Delete(ToDoListStructure.Data.Entity.Alert entity);
		void Delete(List<long> ids);

		ToDoListStructure.Data.Entity.Alert Find(long id);
		List<ToDoListStructure.Data.Entity.Alert> Find();
		Data.Entity.Alert FindByCode(string code);
		List<Data.Entity.Alert> FindByName(string name);
		List<Data.Entity.Alert> FindByAttribute(string att, string value);
	}
}
