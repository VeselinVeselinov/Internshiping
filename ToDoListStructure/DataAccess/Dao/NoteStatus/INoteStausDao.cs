using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.NoteStatus
{
    interface INoteStausDao
    {
        ToDoListStructure.Entities.NoteStatus Save(ToDoListStructure.Entities.NoteStatus entity);
        List<ToDoListStructure.Entities.NoteStatus> Save(List<ToDoListStructure.Entities.NoteStatus> entity);

        ToDoListStructure.Entities.NoteStatus Update(ToDoListStructure.Entities.NoteStatus entity);
        List<ToDoListStructure.Entities.NoteStatus> Update(List<ToDoListStructure.Entities.NoteStatus> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.NoteStatus entity);
        void Delete(List<ToDoListStructure.Entities.NoteStatus> entity);

        ToDoListStructure.Entities.NoteStatus Find(long id);
        List<ToDoListStructure.Entities.NoteStatus> Find();
    }
}
