using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.AlertStatus
{
    interface IAlertStatusProcessor
    {
<<<<<<< Updated upstream
=======
        AlertStatusResult Create(AlertStatusParam param);

        List<AlertStatusResult> Create(List<AlertStatusParam> param);

        void Update(long id, AlertStatusParam param);

        void Update(List<AlertStatusParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        AlertStatusResult Find(long id);

        List<AlertStatusResult> Find();

        AlertStatusResult FindByCode(string code);

        List<AlertStatusResult> FindByName(string name);
>>>>>>> Stashed changes
    }
}
