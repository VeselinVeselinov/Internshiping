using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.Alert;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.Alert
{
    class AlertParamConverter:IAlertParamConverter
    {
        public IAlertDao Dao { get; set; }

        public Entities.Alert Convert(AlertParam param)
        {
            throw new NotImplementedException();
        }
    }
}
