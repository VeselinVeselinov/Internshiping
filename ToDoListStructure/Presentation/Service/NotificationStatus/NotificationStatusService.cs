using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.NotificationStatus;
using ToDoListStructure.Business.Processor.NotificationStatus;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.NotificationStatus
{
    class NotificationStatusService:INotificationStatusService
    {
        public NotificationStatusProcessor Processor { get; set; }

        public Response Create(NotificationStatusParam param)
        {
            throw new NotImplementedException();
        }

        public Response Create(List<NotificationStatusParam> param)
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

        public Response Update(long id, NotificationStatusParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<NotificationStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(NotificationStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<NotificationStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
