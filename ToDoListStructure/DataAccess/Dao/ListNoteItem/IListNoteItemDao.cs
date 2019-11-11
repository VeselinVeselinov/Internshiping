using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ListNoteItem
{
    interface IListNoteItemDao
    {
		ToDoListStructure.Data.Entity.ListNoteItem Save(ToDoListStructure.Data.Entity.ListNoteItem entity);
		List<ToDoListStructure.Data.Entity.ListNoteItem> Save(List<ToDoListStructure.Data.Entity.ListNoteItem> entity);

		ToDoListStructure.Data.Entity.ListNoteItem Update(ToDoListStructure.Data.Entity.ListNoteItem entity);
		List<ToDoListStructure.Data.Entity.ListNoteItem> Update(List<ToDoListStructure.Data.Entity.ListNoteItem> entity);

		void Delete(long id);
		void Delete(ToDoListStructure.Data.Entity.ListNoteItem entity);
		void Delete(List<long> ids);

		ToDoListStructure.Data.Entity.ListNoteItem Find(long id);
		List<ToDoListStructure.Data.Entity.ListNoteItem> Find();
		Data.Entity.ListNoteItem FindByCode(string code);
		List<Data.Entity.ListNoteItem> FindByName(string name);
		List<Data.Entity.ListNoteItem> FindByAttribute(string att, string value);
	}
}
