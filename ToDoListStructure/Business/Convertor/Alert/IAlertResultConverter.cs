using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Alert
{
    interface IAlertResultConverter
    {
        AlertResult Convert(ToDoListStructure.Entities.Alert param);
    }
}
