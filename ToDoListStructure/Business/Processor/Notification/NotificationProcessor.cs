using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Notification;
using ToDoListStructure.DataAccess.Dao.Notification;

namespace ToDoListStructure.Business.Processor.Notification
{
    class NotificationProcessor:INotificationProcessor
    {
        public NotificationDao Dao { get; set; }

        public NotificationParamConverter ParamConverter { get; set; }

        public NotificationResultConverter ResultConverter { get; set; }

        public NotificationResult Create(NotificationParam param)
        {
            throw new NotImplementedException();
        }

        public List<NotificationResult> Create(List<NotificationParam> param)
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

        public NotificationResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<NotificationResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, NotificationParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<NotificationParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
