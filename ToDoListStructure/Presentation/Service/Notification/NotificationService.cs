using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Notification;
using ToDoListStructure.Business.Processor.Notification;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.Notification
{
    class NotificationService:INotificationService
    {
        public INotificationProcessor Processor { get; set; }

        public Response Create(NotificationParam param)
        {
            throw new NotImplementedException();
        }

        public Response Create(List<NotificationParam> param)
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

        public Response Update(long id, NotificationParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<NotificationParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(NotificationParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<NotificationParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
