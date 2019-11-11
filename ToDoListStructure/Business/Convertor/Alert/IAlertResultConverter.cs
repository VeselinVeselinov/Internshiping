using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Alert
{
    interface IAlertResultConverter:IBaseResultConverter<Data.Entity.Alert,AlertResult>
    {
        AlertResult Convert(ToDoListStructure.Data.Entity.Alert param);
    }
}
