using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.AlertStatus
{
    interface IAlertStatusDao
    {
		ToDoListStructure.Data.Entity.AlertStatus Save(ToDoListStructure.Data.Entity.AlertStatus entity);
		List<ToDoListStructure.Data.Entity.AlertStatus> Save(List<ToDoListStructure.Data.Entity.AlertStatus> entity);

		ToDoListStructure.Data.Entity.AlertStatus Update(ToDoListStructure.Data.Entity.AlertStatus entity);
		List<ToDoListStructure.Data.Entity.AlertStatus> Update(List<ToDoListStructure.Data.Entity.AlertStatus> entity);

		void Delete(long id);
		void Delete(ToDoListStructure.Data.Entity.AlertStatus entity);
		void Delete(List<long> ids);

		ToDoListStructure.Data.Entity.AlertStatus Find(long id);
		List<ToDoListStructure.Data.Entity.AlertStatus> Find();
		Data.Entity.AlertStatus FindByCode(string code);
		List<Data.Entity.AlertStatus> FindByName(string name);
		List<Data.Entity.AlertStatus> FindByAttribute(string att, string value);
	}
}
