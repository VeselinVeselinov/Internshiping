using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.TextNote
{
    interface ITextNoteDao
    {
        ToDoListStructure.Data.Entity.TextNote Save(ToDoListStructure.Data.Entity.TextNote entity);
        List<ToDoListStructure.Data.Entity.TextNote> Save(List<ToDoListStructure.Data.Entity.TextNote> entity);

        ToDoListStructure.Data.Entity.TextNote Update(ToDoListStructure.Data.Entity.TextNote entity);
        List<ToDoListStructure.Data.Entity.TextNote> Update(List<ToDoListStructure.Data.Entity.TextNote> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Data.Entity.TextNote entity);
        void Delete(List<ToDoListStructure.Data.Entity.TextNote> entity);

        ToDoListStructure.Data.Entity.TextNote Find(long id);
        List<ToDoListStructure.Data.Entity.TextNote> Find();
    }
}
