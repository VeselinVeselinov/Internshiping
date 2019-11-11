using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.NoteStatus
{
    interface INoteStatusDao
    {
		ToDoListStructure.Data.Entity.NoteStatus Save(ToDoListStructure.Data.Entity.NoteStatus entity);
		List<ToDoListStructure.Data.Entity.NoteStatus> Save(List<ToDoListStructure.Data.Entity.NoteStatus> entity);

		ToDoListStructure.Data.Entity.NoteStatus Update(ToDoListStructure.Data.Entity.NoteStatus entity);
		List<ToDoListStructure.Data.Entity.NoteStatus> Update(List<ToDoListStructure.Data.Entity.NoteStatus> entity);

		void Delete(long id);
		void Delete(ToDoListStructure.Data.Entity.NoteStatus entity);
		void Delete(List<long> ids);

		ToDoListStructure.Data.Entity.NoteStatus Find(long id);
		List<ToDoListStructure.Data.Entity.NoteStatus> Find();
		Data.Entity.NoteStatus FindByCode(string code);
		List<Data.Entity.NoteStatus> FindByName(string name);
		List<Data.Entity.NoteStatus> FindByAttribute(string att, string value);
	}
}
