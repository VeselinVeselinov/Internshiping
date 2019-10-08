using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities.Actions
{
    class Notification:NamedPersistent
    {
        public Alert Alert { get; set; }

        public string NotificationMessage { get; set; }

        public NotificationStatus Status { get; set; }
    }
}
