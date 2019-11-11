using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ShareStatus
{
    interface IShareStatusDao
    {
		ToDoListStructure.Data.Entity.ShareStatus Save(ToDoListStructure.Data.Entity.ShareStatus entity);
		List<ToDoListStructure.Data.Entity.ShareStatus> Save(List<ToDoListStructure.Data.Entity.ShareStatus> entity);

		ToDoListStructure.Data.Entity.ShareStatus Update(ToDoListStructure.Data.Entity.ShareStatus entity);
		List<ToDoListStructure.Data.Entity.ShareStatus> Update(List<ToDoListStructure.Data.Entity.ShareStatus> entity);

		void Delete(long id);
		void Delete(ToDoListStructure.Data.Entity.ShareStatus entity);
		void Delete(List<long> ids);

		ToDoListStructure.Data.Entity.ShareStatus Find(long id);
		List<ToDoListStructure.Data.Entity.ShareStatus> Find();
		Data.Entity.ShareStatus FindByCode(string code);
		List<Data.Entity.ShareStatus> FindByName(string name);
		List<Data.Entity.ShareStatus> FindByAttribute(string att, string value);
	}
}
