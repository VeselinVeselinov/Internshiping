using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.User
{
    interface IUserDao
    {
        ToDoListStructure.Entities.User Save(ToDoListStructure.Entities.User entity);
        List<ToDoListStructure.Entities.User> Save(List<ToDoListStructure.Entities.User> entity);

        ToDoListStructure.Entities.User Update(ToDoListStructure.Entities.User entity);
        List<ToDoListStructure.Entities.User> Update(List<ToDoListStructure.Entities.User> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.User entity);
        void Delete(List<ToDoListStructure.Entities.User> entity);

        ToDoListStructure.Entities.User Find(long id);
        List<ToDoListStructure.Entities.User> Find();
    }
}
