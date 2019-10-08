using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.AlertStatus;

namespace ToDoListStructure.Business.Convertor.AlertStatus
{
    class AlertStatusParamConverter:IAlertStatusParamConverter
    {
        public AlertStatusDao Dao { get; set; }
    }
}
