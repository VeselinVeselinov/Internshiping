using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Alert;
using ToDoListStructure.Business.Processor.Alert;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.Alert
{
    class AlertService:IAlertService
    {
        public AlertProcessor Processor { get; set; }

        public Response Create(AlertParam param)
        {
            throw new NotImplementedException();
        }

        public Response Create(List<AlertParam> param)
        {
            throw new NotImplementedException();
        }

        public Response DeleteByID(long id)
        {
            throw new NotImplementedException();
        }

        public Response Delte(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public Response FindByPK(long id)
        {
            throw new NotImplementedException();
        }

        public Response ListAll()
        {
            throw new NotImplementedException();
        }

        public Response Update(long id, AlertParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<AlertParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(AlertParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AlertParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
