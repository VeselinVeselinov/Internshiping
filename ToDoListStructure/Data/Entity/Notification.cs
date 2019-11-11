using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Data.Entity
{
    class Notification:PersistentNamed
    {
        public Alert Alert { get; set; }

        public string NotificationMessage { get; set; }

        public NotificationStatus Status { get; set; }
    }
}
