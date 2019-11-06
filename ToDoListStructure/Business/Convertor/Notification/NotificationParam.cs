using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Notification
{
    class NotificationParam:BaseParamNamed
    {
		public Entities.Alert Alert { get; set; }

		public string NotificationMessage { get; set; }

		public Entities.NotificationStatus Status { get; set; }
	}
}
