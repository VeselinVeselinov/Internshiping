using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.NotificationStatus;
using ToDoListStructure.DataAccess.Dao.NotificationStatus;

namespace ToDoListStructure.Business.Processor.NotificationStatus
{
    class NotificationStatusProcessor:INotificationStatusProcessor
    {
        public INotificationStatusDao Dao { get; set; }

        public INotificationStatusParamConverter ParamConverter { get; set; }

        public INotificationStatusResultConverter ResultConverter { get; set; }

        public NotificationStatusResult Create(NotificationStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<NotificationStatusResult> Create(List<NotificationStatusParam> param)
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

        public NotificationStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<NotificationStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, NotificationStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<NotificationStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
