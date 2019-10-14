using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.AlertStatus
{
    interface IAlertStatusDao
    {
        ToDoListStructure.Entities.AlertStatus Save(ToDoListStructure.Entities.AlertStatus entity);
        List<ToDoListStructure.Entities.AlertStatus> Save(List<ToDoListStructure.Entities.AlertStatus> entity);

        ToDoListStructure.Entities.AlertStatus Update(ToDoListStructure.Entities.AlertStatus entity);
        List<ToDoListStructure.Entities.AlertStatus> Update(List<ToDoListStructure.Entities.AlertStatus> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.AlertStatus entity);
        void Delete(List<ToDoListStructure.Entities.AlertStatus> entity);

        ToDoListStructure.Entities.AlertStatus Find(long id);
        List<ToDoListStructure.Entities.AlertStatus> Find();
    }
}
