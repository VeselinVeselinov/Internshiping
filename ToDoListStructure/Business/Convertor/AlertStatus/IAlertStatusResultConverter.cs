using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.AlertStatus
{
    interface IAlertStatusResultConverter:IBaseResultConverter<Data.Entity.AlertStatus,AlertStatusResult>
    {
        AlertStatusResult Convert(ToDoListStructure.Data.Entity.AlertStatus param);
    }
}
