using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Share
{
    interface IShareDao
    {
<<<<<<< Updated upstream
=======
        ToDoListStructure.Entities.Share Save(ToDoListStructure.Entities.Share entity);
        List<ToDoListStructure.Entities.Share> Save(List<ToDoListStructure.Entities.Share> entity);

        ToDoListStructure.Entities.Share Update(ToDoListStructure.Entities.Share entity);
        List<ToDoListStructure.Entities.Share> Update(List<ToDoListStructure.Entities.Share> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.Share entity);
        void Delete(List<long> ids);

        ToDoListStructure.Entities.Share Find(long id);
        List<ToDoListStructure.Entities.Share> Find();
>>>>>>> Stashed changes
    }
}
