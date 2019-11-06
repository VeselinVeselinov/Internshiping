using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ListNote
{
    interface IListNoteDao
    {
<<<<<<< Updated upstream
=======
        ToDoListStructure.Entities.ListNote Save(ToDoListStructure.Entities.ListNote entity);
        List<ToDoListStructure.Entities.ListNote> Save(List<ToDoListStructure.Entities.ListNote> entity);

        ToDoListStructure.Entities.ListNote Update(ToDoListStructure.Entities.ListNote entity);
        List<ToDoListStructure.Entities.ListNote> Update(List<ToDoListStructure.Entities.ListNote> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.ListNote entity);
        void Delete(List<long> ids);

        ToDoListStructure.Entities.ListNote Find(long id);
        List<ToDoListStructure.Entities.ListNote> Find();
        Entities.ListNote FindByCode(string code);
        List<Entities.ListNote> FindByName(string name);
>>>>>>> Stashed changes
    }
}
