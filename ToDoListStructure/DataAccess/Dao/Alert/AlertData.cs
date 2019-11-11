using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.DataAccess.Dao.AlertStatus;

namespace ToDoListStructure.DataAccess.Dao.Alert
{
	class AlertData
	{
		public static List<Data.Entity.Alert> Storage;
		public static IDictionary<long, Data.Entity.Alert> Data;

		static AlertData()
		{
			Data = new Dictionary<long, Data.Entity.Alert>();
			Storage = new List<Data.Entity.Alert>()
			{
				new Data.Entity.Alert()
				{
					Id=1,
					Code="1",
					Name="First",
					Description="First test",
					Note=null,
					TimeReminder=DateTime.Now,
					Status=AlertStatusData.Data.Where(statusItem=>statusItem.Key.Equals(1)).Single().Value
				},
				new Data.Entity.Alert()
				{
					Id=2,
					Code="2",
					Name="Second",
					Description="Second test",
					Note=null,
					TimeReminder=DateTime.UtcNow,
					Status=AlertStatusData.Data.Where(statusItem=>statusItem.Key.Equals(2)).Single().Value
				},
				new Data.Entity.Alert()
				{
					Id=3,
					Code="3",
					Name="Third",
					Description="Third test",
					Note=null,
					TimeReminder=DateTime.Now,
					Status=AlertStatusData.Data.Where(statusItem=>statusItem.Key.Equals(3)).Single().Value
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
