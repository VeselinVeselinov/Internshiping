using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ImageNote
{
    interface IImageNoteDao
    {
<<<<<<< Updated upstream
=======
        ToDoListStructure.Entities.ImageNote Save(ToDoListStructure.Entities.ImageNote entity);
        List<ToDoListStructure.Entities.ImageNote> Save(List<ToDoListStructure.Entities.ImageNote> entity);

        ToDoListStructure.Entities.ImageNote Update(ToDoListStructure.Entities.ImageNote entity);
        List<ToDoListStructure.Entities.ImageNote> Update(List<ToDoListStructure.Entities.ImageNote> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.ImageNote entity);
        void Delete(List<long> ids);

        ToDoListStructure.Entities.ImageNote Find(long id);
        List<ToDoListStructure.Entities.ImageNote> Find();
        Entities.ImageNote FindByCode(string code);
        List<Entities.ImageNote> FindByName(string name);
>>>>>>> Stashed changes
    }
}
