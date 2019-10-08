using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.Alert;

namespace ToDoListStructure.Business.Convertor.Alert
{
    class AlertParamConverter:IAlertParamConverter
    {
        public AlertDao Dao { get; set; }
    }
}
