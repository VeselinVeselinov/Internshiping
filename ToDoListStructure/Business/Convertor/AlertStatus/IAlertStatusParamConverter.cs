using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.AlertStatus
{
    interface IAlertStatusParamConverter
    {
        ToDoListStructure.Entities.AlertStatus Convert(AlertStatusParam param);
    }
}
