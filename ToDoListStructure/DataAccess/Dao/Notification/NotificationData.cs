using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.DataAccess.Dao.Alert;
using ToDoListStructure.DataAccess.Dao.NotificationStatus;

namespace ToDoListStructure.DataAccess.Dao.Notification
{
	class NotificationData
	{
		public static List<Data.Entity.Notification> Storage;
		public static IDictionary<long, Data.Entity.Notification> Data;

		static NotificationData()
		{
			Data = new Dictionary<long, Data.Entity.Notification>();
			Storage = new List<Data.Entity.Notification>()
			{
				new Data.Entity.Notification()
				{
					Id=1,
					Code="Notif1",
					Name="First",
					Description="First tester notification on the system.",
					Alert=AlertData.Data.Where(alertItem=>alertItem.Key.Equals(1)).Single().Value,
					NotificationMessage="Testing message",
					Status=NotificationStatusData.Data.Where(notif=>notif.Key.Equals(1)).Single().Value
				},
				new Data.Entity.Notification()
				{
					Id=2,
					Code="Notif2",
					Name="Second",
					Description="Second tester notification on the system.",
					Alert=AlertData.Data.Where(alertItem=>alertItem.Key.Equals(2)).Single().Value,
					NotificationMessage="Testing message",
					Status=NotificationStatusData.Data.Where(notif=>notif.Key.Equals(2)).Single().Value
				},
				new Data.Entity.Notification()
				{
					Id=3,
					Code="Notif3",
					Name="Third",
					Description="Third tester notification tester on the system.",
					Alert=AlertData.Data.Where(alertItem=>alertItem.Key.Equals(3)).Single().Value,
					NotificationMessage="Testing message",
					Status=NotificationStatusData.Data.Where(notif=>notif.Key.Equals(3)).Single().Value
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
