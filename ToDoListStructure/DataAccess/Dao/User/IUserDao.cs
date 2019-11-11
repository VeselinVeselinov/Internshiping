using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.User
{
    interface IUserDao
    {
		ToDoListStructure.Data.Entity.User Save(ToDoListStructure.Data.Entity.User entity);
		List<ToDoListStructure.Data.Entity.User> Save(List<ToDoListStructure.Data.Entity.User> entity);

		ToDoListStructure.Data.Entity.User Update(ToDoListStructure.Data.Entity.User entity);
		List<ToDoListStructure.Data.Entity.User> Update(List<ToDoListStructure.Data.Entity.User> entity);

		void Delete(long id);
		void Delete(ToDoListStructure.Data.Entity.User entity);
		void Delete(List<long> ids);

		ToDoListStructure.Data.Entity.User Find(long id);
		List<ToDoListStructure.Data.Entity.User> Find();
	}
}
