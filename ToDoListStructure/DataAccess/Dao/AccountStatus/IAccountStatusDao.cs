using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.AccountStatus
{
    interface IAccountStatusDao
    {
		ToDoListStructure.Data.Entity.AccountStatus Save(ToDoListStructure.Data.Entity.AccountStatus entity);
		List<ToDoListStructure.Data.Entity.AccountStatus> Save(List<ToDoListStructure.Data.Entity.AccountStatus> entity);

		ToDoListStructure.Data.Entity.AccountStatus Update(ToDoListStructure.Data.Entity.AccountStatus entity);
		List<ToDoListStructure.Data.Entity.AccountStatus> Update(List<ToDoListStructure.Data.Entity.AccountStatus> entity);

		void Delete(long id);
		void Delete(ToDoListStructure.Data.Entity.AccountStatus entity);
		void Delete(List<long> ids);

		ToDoListStructure.Data.Entity.AccountStatus Find(long id);
		List<ToDoListStructure.Data.Entity.AccountStatus> Find();
		Data.Entity.AccountStatus FindByCode(string code);
		List<Data.Entity.AccountStatus> FindByName(string name);
		List<Data.Entity.AccountStatus> FindByAttribute(string att, string value);
	}
}
