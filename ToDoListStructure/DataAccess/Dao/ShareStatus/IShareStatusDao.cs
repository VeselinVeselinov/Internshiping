using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ShareStatus
{
    interface IShareStatusDao
    {
<<<<<<< Updated upstream
=======
        ToDoListStructure.Entities.ShareStatus Save(ToDoListStructure.Entities.ShareStatus entity);
        List<ToDoListStructure.Entities.ShareStatus> Save(List<ToDoListStructure.Entities.ShareStatus> entity);

        ToDoListStructure.Entities.ShareStatus Update(ToDoListStructure.Entities.ShareStatus entity);
        List<ToDoListStructure.Entities.ShareStatus> Update(List<ToDoListStructure.Entities.ShareStatus> entity);

        void Delete(long id);
        void Delete(ToDoListStructure.Entities.ShareStatus entity);
        void Delete(List<long> ids);

        ToDoListStructure.Entities.ShareStatus Find(long id);
        List<ToDoListStructure.Entities.ShareStatus> Find();
		Entities.ShareStatus FindByCode(string code);
		List<Entities.ShareStatus> FindByName(string name);
>>>>>>> Stashed changes
    }
}
