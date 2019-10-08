using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.AlertStatus;
using ToDoListStructure.DataAccess.Dao.AlertStatus;

namespace ToDoListStructure.Business.Processor.AlertStatus
{
    class AlertStatusProcessor:IAlertStatusProcessor
    {
        public AlertStatusDao Dao { get; set; }

        public AlertStatusParamConverter ParamConverter { get; set; }

        public AlertStatusResultConverter ResultConverter { get; set; }
    }
}
