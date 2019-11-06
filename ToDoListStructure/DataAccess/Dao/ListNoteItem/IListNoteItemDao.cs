using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ListNoteItem
{
    interface IListNoteItemDao
    {
<<<<<<< Updated upstream
=======
        ToDoListStructure.Entities.ListNoteItem Save(ToDoListStructure.Entities.ListNoteItem entity);
        List<ToDoListStructure.Entities.ListNoteItem> Save(List<ToDoListStructure.Entities.ListNoteItem> entity);

        ToDoListStructure.Entities.ListNoteItem Update(ToDoListStructure.Entities.ListNoteItem entity);
        List<ToDoListStructure.Entities.ListNoteItem> Update(List<ToDoListStructure.Entities.ListNoteItem> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.ListNoteItem entity);
        void Delete(List<long> ids);

        ToDoListStructure.Entities.ListNoteItem Find(long id);
        List<ToDoListStructure.Entities.ListNoteItem> Find();
        Entities.ListNoteItem FindByCode(string code);
        List<Entities.ListNoteItem> FindByName(string name);
>>>>>>> Stashed changes
    }
}
