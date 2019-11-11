using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.AccountStatus
{
    class AccountStatusData
    {
		public static List<Data.Entity.AccountStatus> Storage;

		public static IDictionary<long, Data.Entity.AccountStatus> Data;

		static AccountStatusData()
		{
			Data = new Dictionary<long, Data.Entity.AccountStatus>();
			Storage = new List<Data.Entity.AccountStatus>()
			{
				new Data.Entity.AccountStatus()
				{
					Id=1,
					Code="FirstAccStatus",
					Name="Active",
					Description="The first acount status test in the system."
				},
				new Data.Entity.AccountStatus()
				{
					Id=2,
					Code="SecondAccStatus",
					Name="Active",
					Description="The second acount status test in the system."
				},
				new Data.Entity.AccountStatus()
				{
					Id=3,
					Code="ThirdAccStatus",
					Name="Active",
					Description="The third acount status test in the system."
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
