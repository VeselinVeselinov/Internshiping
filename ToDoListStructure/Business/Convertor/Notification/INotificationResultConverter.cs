﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Notification
{
    interface INotificationResultConverter
    {
        NotificationResult Convert(ToDoListStructure.Entities.Notification param);
    }
}
