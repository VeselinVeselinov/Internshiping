using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Account
{
    interface IAccountDao
    {
		ToDoListStructure.Data.Entity.Account Save(ToDoListStructure.Data.Entity.Account entity);
		List<ToDoListStructure.Data.Entity.Account> Save(List<ToDoListStructure.Data.Entity.Account> entity);

		ToDoListStructure.Data.Entity.Account Update(ToDoListStructure.Data.Entity.Account entity);
		List<ToDoListStructure.Data.Entity.Account> Update(List<ToDoListStructure.Data.Entity.Account> entity);

		void Delete(long id);
		void Delete(ToDoListStructure.Data.Entity.Account entity);
		void Delete(List<long> ids);

		ToDoListStructure.Data.Entity.Account Find(long id);
		List<ToDoListStructure.Data.Entity.Account> Find();
		Data.Entity.Account FindByCode(string code);
		List<Data.Entity.Account> FindByName(string name);
		List<Data.Entity.Account> FindByAttribute(string att, string value);
	}
}
