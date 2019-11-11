using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ShareStatus
{
	class ShareStatusData
	{
		public static List<Data.Entity.ShareStatus> Storage;
		public static IDictionary<long, Data.Entity.ShareStatus> Data;

		static ShareStatusData()
		{
			Data = new Dictionary<long, Data.Entity.ShareStatus>();
			Storage = new List<Data.Entity.ShareStatus>()
			{
				new Data.Entity.ShareStatus()
				{
					Id=1,
					Code="ShareStat1",
					Name="First",
					Description="This is the first share status test in the system."
				},
				new Data.Entity.ShareStatus()
				{
					Id=2,
					Code="ShareStat2",
					Name="Second",
					Description="This is the second share status test in the system."
				},
				new Data.Entity.ShareStatus()
				{
					Id=3,
					Code="ShareStat3",
					Name="Third",
					Description="This is the third share status test in the system."
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
