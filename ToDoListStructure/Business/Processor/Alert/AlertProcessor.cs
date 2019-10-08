using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Alert;
using ToDoListStructure.DataAccess.Dao.Alert;

namespace ToDoListStructure.Business.Processor.Alert
{
    class AlertProcessor:IAlertProcessor
    {
        public AlertDao Dao { get; set; }

        public AlertParamConverter ParamConverter { get; set; }

        public AlertResultConverter ResultConverter { get; set; }
    }
}
