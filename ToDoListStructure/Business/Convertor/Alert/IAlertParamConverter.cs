using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Alert
{
    interface IAlertParamConverter:IBaseParamConverter<AlertParam,Data.Entity.Alert>
    {
        ToDoListStructure.Data.Entity.Alert Convert(AlertParam param,Data.Entity.Alert oldEntity);
    }
}
