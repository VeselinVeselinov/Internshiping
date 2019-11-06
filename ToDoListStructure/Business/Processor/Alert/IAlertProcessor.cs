using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.Alert
{
    interface IAlertProcessor
    {
<<<<<<< Updated upstream
=======
        AlertResult Create(AlertParam param);

        List<AlertResult> Create(List<AlertParam> param);

        void Update(long id, AlertParam param);

        void Update(List<AlertParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        AlertResult Find(long id);

        List<AlertResult> Find();

        AlertResult FindByCode(string code);

        List<AlertResult> FindByName(string name);
>>>>>>> Stashed changes
    }
}
