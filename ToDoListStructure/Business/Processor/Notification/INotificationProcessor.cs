using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Notification;

namespace ToDoListStructure.Business.Processor.Notification
{
    interface INotificationProcessor
    {
        NotificationResult Create(NotificationParam param);

        List<NotificationResult> Create(List<NotificationParam> param);

        void Update(long id, NotificationParam param);

        void Update(List<NotificationParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        NotificationResult Find(long id);

        List<NotificationResult> Find();
    }
}
