using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.UserStatus
{
	class UserStatusData
	{
		public static List<Data.Entity.UserStatus> Storage;
		public static IDictionary<long, Data.Entity.UserStatus> Data;

		static UserStatusData()
		{
			Data = new Dictionary<long, Data.Entity.UserStatus>();
			Storage = new List<Data.Entity.UserStatus>()
			{
				new Data.Entity.UserStatus()
				{
					Id=1,
					Code="UsrStat1",
					Name="FirsterSts",
					Description="The first user status test in the system."
				},
				new Data.Entity.UserStatus()
				{
					Id=2,
					Code="UsrStat2",
					Name="SeconderSts",
					Description="The second user status test in the system."
				},
				new Data.Entity.UserStatus()
				{
					Id=3,
					Code="UsrStat3",
					Name="ThirderSts",
					Description="The third user status test in the system."
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
