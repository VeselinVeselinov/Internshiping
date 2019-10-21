using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.AlertStatus;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.AlertStatus
{
    class AlertStatusParamConverter:IAlertStatusParamConverter
    {
        public IAlertStatusDao Dao { get; set; }

        public Entities.AlertStatus Convert(AlertStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
