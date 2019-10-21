using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.AlertStatus;
using ToDoListStructure.DataAccess.Dao.AlertStatus;

namespace ToDoListStructure.Business.Processor.AlertStatus
{
    class AlertStatusProcessor:IAlertStatusProcessor
    {
        public IAlertStatusDao Dao { get; set; }

        public IAlertStatusParamConverter ParamConverter { get; set; }

        public IAlertStatusResultConverter ResultConverter { get; set; }

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
