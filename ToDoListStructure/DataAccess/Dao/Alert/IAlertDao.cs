using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Alert
{
    interface IAlertDao
    {
<<<<<<< Updated upstream
=======
        ToDoListStructure.Entities.Alert Save(ToDoListStructure.Entities.Alert entity);
        List<ToDoListStructure.Entities.Alert> Save(List<ToDoListStructure.Entities.Alert> entity);

        ToDoListStructure.Entities.Alert Update(ToDoListStructure.Entities.Alert entity);
        List<ToDoListStructure.Entities.Alert> Update(List<ToDoListStructure.Entities.Alert> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.Alert entity);
        void Delete(List<long> ids);

        ToDoListStructure.Entities.Alert Find(long id);
        List<ToDoListStructure.Entities.Alert> Find();
        Entities.Alert FindByCode(string code);
        List<Entities.Alert> FindByName(string name);
>>>>>>> Stashed changes
    }
}
