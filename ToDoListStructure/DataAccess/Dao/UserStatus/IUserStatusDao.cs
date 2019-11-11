using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.UserStatus
{
    interface IUserStatusDao
    {
		ToDoListStructure.Data.Entity.UserStatus Save(ToDoListStructure.Data.Entity.UserStatus entity);
		List<ToDoListStructure.Data.Entity.UserStatus> Save(List<ToDoListStructure.Data.Entity.UserStatus> entity);

		ToDoListStructure.Data.Entity.UserStatus Update(ToDoListStructure.Data.Entity.UserStatus entity);
		List<ToDoListStructure.Data.Entity.UserStatus> Update(List<ToDoListStructure.Data.Entity.UserStatus> entity);

		void Delete(long id);
		void Delete(ToDoListStructure.Data.Entity.UserStatus entity);
		void Delete(List<long> ids);

		ToDoListStructure.Data.Entity.UserStatus Find(long id);
		List<ToDoListStructure.Data.Entity.UserStatus> Find();
		Data.Entity.UserStatus FindByCode(string code);
		List<Data.Entity.UserStatus> FindByName(string name);
		List<Data.Entity.UserStatus> FindByAttribute(string att, string value);
	}
}
