using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.NotificationStatus;

namespace ToDoListStructure.Business.Processor.NotificationStatus
{
    interface INotificationStatusProcessor
    {
        NotificationStatusResult Create(NotificationStatusParam param);

        List<NotificationStatusResult> Create(List<NotificationStatusParam> param);

        void Update(long id, NotificationStatusParam param);

        void Update(List<NotificationStatusParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        NotificationStatusResult Find(long id);

        List<NotificationStatusResult> Find();
    }
}
