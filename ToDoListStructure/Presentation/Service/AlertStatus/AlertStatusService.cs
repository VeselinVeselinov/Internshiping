using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.AlertStatus;
using ToDoListStructure.Business.Processor.AlertStatus;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.AlertStatus
{
    class AlertStatusService:IAlertStatusService
    {
        public IAlertStatusProcessor Processor { get; set; }

        public Response Create(AlertStatusParam param)
        {
            throw new NotImplementedException();
        }

        public Response Create(List<AlertStatusParam> param)
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

        public Response Update(long id, AlertStatusParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<AlertStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(AlertStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AlertStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
