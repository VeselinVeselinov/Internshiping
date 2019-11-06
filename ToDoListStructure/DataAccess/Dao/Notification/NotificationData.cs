using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Notification
{
	class NotificationData
	{
		public static List<Entities.Notification> Storage;
		public static IDictionary<long, Entities.Notification> Data;

		static NotificationData()
		{
			Data = new Dictionary<long, Entities.Notification>();
			Storage = new List<Entities.Notification>()
			{
				new Entities.Notification()
				{
					Id=1,
					Code="One",
					Name="First",
					Description="First tester",
					Alert=null,
					NotificationMessage="Testing message",
					Status=null

				},
				new Entities.Notification()
				{
					Id=2,
					Code="Two",
					Name="Second",
					Description="Second tester",
					Alert=null,
					NotificationMessage="Testing message",
					Status=null
				},
				new Entities.Notification()
				{
					Id=3,
					Code="Three",
					Name="Third",
					Description="Third tester",
					Alert=null,
					NotificationMessage="Testing message",
					Status=null
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
