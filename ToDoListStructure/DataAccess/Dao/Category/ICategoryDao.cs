using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Category
{
    interface ICategoryDao
    {
<<<<<<< Updated upstream
=======
        ToDoListStructure.Entities.Category Save(ToDoListStructure.Entities.Category entity);
        List<ToDoListStructure.Entities.Category> Save(List<ToDoListStructure.Entities.Category> entity);

        ToDoListStructure.Entities.Category Update(ToDoListStructure.Entities.Category entity);
        List<ToDoListStructure.Entities.Category> Update(List<ToDoListStructure.Entities.Category> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.Category entity);
        void Delete(List<long> ids);

        ToDoListStructure.Entities.Category Find(long id);
        List<ToDoListStructure.Entities.Category> Find();
        Entities.Category FindByCode(string code);
        List<Entities.Category> FindByName(string name);
>>>>>>> Stashed changes
    }
}
