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

        public AlertStatusResult Create(AlertStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<AlertStatusResult> Create(List<AlertStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public AlertStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<AlertStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, AlertStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<AlertStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
