using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.UserStatus
{
    interface IUserStatusDao
    {
        ToDoListStructure.Entities.UserStatus Save(ToDoListStructure.Entities.UserStatus entity);
        List<ToDoListStructure.Entities.UserStatus> Save(List<ToDoListStructure.Entities.UserStatus> entity);

        ToDoListStructure.Entities.UserStatus Update(ToDoListStructure.Entities.UserStatus entity);
        List<ToDoListStructure.Entities.UserStatus> Update(List<ToDoListStructure.Entities.UserStatus> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.UserStatus entity);
        void Delete(List<ToDoListStructure.Entities.UserStatus> entity);

        ToDoListStructure.Entities.UserStatus Find(long id);
        List<ToDoListStructure.Entities.UserStatus> Find();
    }
}
