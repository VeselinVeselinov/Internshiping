using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.AlertStatus
{
    interface IAlertStatusParamConverter:IBaseParamConverter<AlertStatusParam,Data.Entity.AlertStatus>
    {
        ToDoListStructure.Data.Entity.AlertStatus Convert(AlertStatusParam param,Data.Entity.AlertStatus oldEntity);
    }
}
