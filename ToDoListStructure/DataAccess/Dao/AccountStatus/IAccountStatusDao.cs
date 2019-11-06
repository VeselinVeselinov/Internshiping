using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.AccountStatus
{
    interface IAccountStatusDao
    {
<<<<<<< Updated upstream
=======
        ToDoListStructure.Entities.AccountStatus Save(ToDoListStructure.Entities.AccountStatus entity);
        List<ToDoListStructure.Entities.AccountStatus> Save(List<ToDoListStructure.Entities.AccountStatus> entity);

        ToDoListStructure.Entities.AccountStatus Update(ToDoListStructure.Entities.AccountStatus entity);
        List<ToDoListStructure.Entities.AccountStatus> Update(List<ToDoListStructure.Entities.AccountStatus> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.AccountStatus entity);
        void Delete(List<long> ids);

        ToDoListStructure.Entities.AccountStatus Find(long id);
        List<ToDoListStructure.Entities.AccountStatus> Find();
        Entities.AccountStatus FindByCode(string code);
        List<Entities.AccountStatus> FindByName(string name);
>>>>>>> Stashed changes
    }
}
