using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.AlertStatus;

namespace ToDoListStructure.Business.Processor.AlertStatus
{
    interface IAlertStatusProcessor
    {
        AlertStatusResult Create(AlertStatusParam param);

        List<AlertStatusResult> Create(List<AlertStatusParam> param);

        void Update(long id, AlertStatusParam param);

        void Update(List<AlertStatusParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        AlertStatusResult Find(long id);

        List<AlertStatusResult> Find();
    }
}
