using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Category
{
    interface ICategoryDao
    {
		ToDoListStructure.Data.Entity.Category Save(ToDoListStructure.Data.Entity.Category entity);
		List<ToDoListStructure.Data.Entity.Category> Save(List<ToDoListStructure.Data.Entity.Category> entity);

		ToDoListStructure.Data.Entity.Category Update(ToDoListStructure.Data.Entity.Category entity);
		List<ToDoListStructure.Data.Entity.Category> Update(List<ToDoListStructure.Data.Entity.Category> entity);

		void Delete(long id);
		void Delete(ToDoListStructure.Data.Entity.Category entity);
		void Delete(List<long> ids);

		ToDoListStructure.Data.Entity.Category Find(long id);
		List<ToDoListStructure.Data.Entity.Category> Find();
		Data.Entity.Category FindByCode(string code);
		List<Data.Entity.Category> FindByName(string name);
		List<Data.Entity.Category> FindByAttribute(string att, string value);
	}
}
