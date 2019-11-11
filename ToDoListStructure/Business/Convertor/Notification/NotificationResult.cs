using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Notification
{
    class NotificationResult:BaseResultNamed
    {
		public long AlertId { get; set; }

		public string AlertName { get; set; }

		public string NotificationMessage { get; set; }

		public long StatusId { get; set; }

		public string StatusName { get; set; }
	}
}
