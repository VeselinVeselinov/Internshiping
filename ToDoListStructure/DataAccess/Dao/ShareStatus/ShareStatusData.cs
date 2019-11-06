using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ShareStatus
{
	class ShareStatusData
	{
		public static List<Entities.ShareStatus> Storage;
		public static IDictionary<long, Entities.ShareStatus> Data;

		static ShareStatusData()
		{
			Data = new Dictionary<long, Entities.ShareStatus>();
			Storage = new List<Entities.ShareStatus>()
			{
				new Entities.ShareStatus()
				{
					Id=1,
					Code="First test share status",
					Name="First",
					Description="This is the first share status test in the system"
				},
				new Entities.ShareStatus()
				{
					Id=2,
					Code="Second test share status",
					Name="Second",
					Description="This is the second share status test in the system"
				},
				new Entities.ShareStatus()
				{
					Id=3,
					Code="Third test share status",
					Name="Third",
					Description="This is the third share status test in the system"
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
