using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Account
{
    interface IAccountDao
    {
        ToDoListStructure.Entities.Account Save(ToDoListStructure.Entities.Account entity);
        List<ToDoListStructure.Entities.Account> Save(List<ToDoListStructure.Entities.Account> entity);

        ToDoListStructure.Entities.Account Update(ToDoListStructure.Entities.Account entity);
        List<ToDoListStructure.Entities.Account> Update(List<ToDoListStructure.Entities.Account> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.Account entity);
        void Delete(List<ToDoListStructure.Entities.Account> entity);

        ToDoListStructure.Entities.Account Find(long id);
        List<ToDoListStructure.Entities.Account> Find();
    }
}
