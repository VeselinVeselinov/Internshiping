using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Share
{
    interface IShareDao
    {
		ToDoListStructure.Data.Entity.Share Save(ToDoListStructure.Data.Entity.Share entity);
		List<ToDoListStructure.Data.Entity.Share> Save(List<ToDoListStructure.Data.Entity.Share> entity);

		ToDoListStructure.Data.Entity.Share Update(ToDoListStructure.Data.Entity.Share entity);
		List<ToDoListStructure.Data.Entity.Share> Update(List<ToDoListStructure.Data.Entity.Share> entity);

		void Delete(long id);
		void Delete(ToDoListStructure.Data.Entity.Share entity);
		void Delete(List<long> ids);

		ToDoListStructure.Data.Entity.Share Find(long id);
		List<ToDoListStructure.Data.Entity.Share> Find();
	}
}
