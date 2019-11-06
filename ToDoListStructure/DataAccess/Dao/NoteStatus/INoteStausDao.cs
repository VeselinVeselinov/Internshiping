using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.NoteStatus
{
    interface INoteStausDao
    {
<<<<<<< Updated upstream
=======
        ToDoListStructure.Entities.NoteStatus Save(ToDoListStructure.Entities.NoteStatus entity);
        List<ToDoListStructure.Entities.NoteStatus> Save(List<ToDoListStructure.Entities.NoteStatus> entity);

        ToDoListStructure.Entities.NoteStatus Update(ToDoListStructure.Entities.NoteStatus entity);
        List<ToDoListStructure.Entities.NoteStatus> Update(List<ToDoListStructure.Entities.NoteStatus> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.NoteStatus entity);
        void Delete(List<long> ids);

        ToDoListStructure.Entities.NoteStatus Find(long id);
        List<ToDoListStructure.Entities.NoteStatus> Find();
        Entities.NoteStatus FindByCode(string code);
        List<Entities.NoteStatus> FindByName(string name);
>>>>>>> Stashed changes
    }
}
