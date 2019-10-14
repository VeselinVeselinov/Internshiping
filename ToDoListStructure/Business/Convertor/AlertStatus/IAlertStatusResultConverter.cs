using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.AlertStatus
{
    interface IAlertStatusResultConverter
    {
        AlertStatusResult Convert(ToDoListStructure.Entities.AlertStatus param);
    }
}
