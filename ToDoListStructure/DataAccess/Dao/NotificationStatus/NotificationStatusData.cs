using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.NotificationStatus
{
	class NotificationStatusData
	{
		public static List<Data.Entity.NotificationStatus> Storage;
		public static IDictionary<long, Data.Entity.NotificationStatus> Data;

		static NotificationStatusData()
		{
			Data = new Dictionary<long, Data.Entity.NotificationStatus>();
			Storage = new List<Data.Entity.NotificationStatus>()
			{
				new Data.Entity.NotificationStatus()
				{
					Id=1,
					Code="NotifStatus1",
					Name="First",
					Description="First tester notification status on the system.",
				},
				new Data.Entity.NotificationStatus()
				{
					Id=2,
					Code="NotifStatus2",
					Name="Second",
					Description="Second tester notification status on the system.",
				},
				new Data.Entity.NotificationStatus()
				{
					Id=3,
					Code="NotifStatus3",
					Name="Third",
					Description="Third tester notification status on the system.",
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
