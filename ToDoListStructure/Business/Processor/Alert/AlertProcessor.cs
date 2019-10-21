using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Alert;
using ToDoListStructure.DataAccess.Dao.Alert;

namespace ToDoListStructure.Business.Processor.Alert
{
    class AlertProcessor:IAlertProcessor
    {
        public IAlertDao Dao { get; set; }

        public IAlertParamConverter ParamConverter { get; set; }

        public IAlertResultConverter ResultConverter { get; set; }

        public AlertResult Create(AlertParam param)
        {
            throw new NotImplementedException();
        }

        public List<AlertResult> Create(List<AlertParam> param)
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

        public AlertResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<AlertResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, AlertParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<AlertParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
