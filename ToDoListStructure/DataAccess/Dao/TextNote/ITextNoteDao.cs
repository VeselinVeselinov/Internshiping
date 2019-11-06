using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.TextNote
{
    interface ITextNoteDao
    {
<<<<<<< Updated upstream
=======
        ToDoListStructure.Entities.TextNote Save(ToDoListStructure.Entities.TextNote entity);
        List<ToDoListStructure.Entities.TextNote> Save(List<ToDoListStructure.Entities.TextNote> entity);

        ToDoListStructure.Entities.TextNote Update(ToDoListStructure.Entities.TextNote entity);
        List<ToDoListStructure.Entities.TextNote> Update(List<ToDoListStructure.Entities.TextNote> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.TextNote entity);
        void Delete(List<long> ids);

        ToDoListStructure.Entities.TextNote Find(long id);
        List<ToDoListStructure.Entities.TextNote> Find();
		Entities.TextNote FindByCode(string code);
		List<Entities.TextNote> FindByName(string name);
>>>>>>> Stashed changes
    }
}
