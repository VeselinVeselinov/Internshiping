using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.NotificationStatus
{
	class NotificationStatusData
	{
		public static List<Entities.NotificationStatus> Storage;
		public static IDictionary<long, Entities.NotificationStatus> Data;

		static NotificationStatusData()
		{
			Data = new Dictionary<long, Entities.NotificationStatus>();
			Storage = new List<Entities.NotificationStatus>()
			{
				new Entities.NotificationStatus()
				{
					Id=1,
					Code="One",
					Name="First",
					Description="First tester",
				},
				new Entities.NotificationStatus()
				{
					Id=2,
					Code="Two",
					Name="Second",
					Description="Second tester",
				},
				new Entities.NotificationStatus()
				{
					Id=3,
					Code="Three",
					Name="Third",
					Description="Third tester",
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
