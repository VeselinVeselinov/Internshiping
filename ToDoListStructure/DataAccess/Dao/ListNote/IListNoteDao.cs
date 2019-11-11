using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ListNote
{
    interface IListNoteDao
    {
        ToDoListStructure.Data.Entity.ListNote Save(ToDoListStructure.Data.Entity.ListNote entity);
        List<ToDoListStructure.Data.Entity.ListNote> Save(List<ToDoListStructure.Data.Entity.ListNote> entity);

        ToDoListStructure.Data.Entity.ListNote Update(ToDoListStructure.Data.Entity.ListNote entity);
        List<ToDoListStructure.Data.Entity.ListNote> Update(List<ToDoListStructure.Data.Entity.ListNote> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Data.Entity.ListNote entity);
        void Delete(List<ToDoListStructure.Data.Entity.ListNote> entity);

        ToDoListStructure.Data.Entity.ListNote Find(long id);
        List<ToDoListStructure.Data.Entity.ListNote> Find();
    }
}
