using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Alert;

namespace ToDoListStructure.Business.Processor.Alert
{
    interface IAlertProcessor
    {
        AlertResult Create(AlertParam param);

        List<AlertResult> Create(List<AlertParam> param);

        void Update(long id, AlertParam param);

        void Update(List<AlertParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        AlertResult Find(long id);

        List<AlertResult> Find();
    }
}
