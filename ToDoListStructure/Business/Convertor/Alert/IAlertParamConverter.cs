using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Alert
{
    interface IAlertParamConverter
    {
        ToDoListStructure.Entities.Alert Convert(AlertParam param);
    }
}
