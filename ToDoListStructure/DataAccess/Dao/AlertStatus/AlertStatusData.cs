using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.AlertStatus
{
	class AlertStatusData
	{
		public static List<Data.Entity.AlertStatus> Storage;
		public static IDictionary<long, Data.Entity.AlertStatus> Data;

		static AlertStatusData()
		{
			Data = new Dictionary<long, Data.Entity.AlertStatus>();
			Storage = new List<Data.Entity.AlertStatus>()
			{
				new Data.Entity.AlertStatus()
				{
					Id=1,
					Code="AlrtStatus1",
					Name="First",
					Description="First tester alert status on the system."
				},
				new Data.Entity.AlertStatus()
				{
					Id=2,
					Code="AlrtStatus2",
					Name="Second",
					Description="Second tester alert status on the system."
				},
				new Data.Entity.AlertStatus()
				{
					Id=3,
					Code="AlrtStatus3",
					Name="Third",
					Description="Third tester alert status on the system."
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
