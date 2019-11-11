using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ImageNote
{
    interface IImageNoteDao
    {
        ToDoListStructure.Data.Entity.ImageNote Save(ToDoListStructure.Data.Entity.ImageNote entity);
        List<ToDoListStructure.Data.Entity.ImageNote> Save(List<ToDoListStructure.Data.Entity.ImageNote> entity);

        ToDoListStructure.Data.Entity.ImageNote Update(ToDoListStructure.Data.Entity.ImageNote entity);
        List<ToDoListStructure.Data.Entity.ImageNote> Update(List<ToDoListStructure.Data.Entity.ImageNote> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Data.Entity.ImageNote entity);
        void Delete(List<ToDoListStructure.Data.Entity.ImageNote> entity);

        ToDoListStructure.Data.Entity.ImageNote Find(long id);
        List<ToDoListStructure.Data.Entity.ImageNote> Find();
    }
}
