using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.AccountStatus
{
    class AccountStatusData
    {
        public static List<Entities.AccountStatus> Storage;

        public static IDictionary<long, Entities.AccountStatus> Data;

        static AccountStatusData()
        {
            Data = new Dictionary<long, Entities.AccountStatus>();
			Storage = new List<Entities.AccountStatus>()
			{
				new Entities.AccountStatus()
				{
					Id=1,
					Code="FirstAccStatus",
					Name="Active",
					Description="The first acount status test in the system."
                },
                new Entities.AccountStatus()
                {
					Id=2,
                    Code="SecondAccStatus",
                    Name="Active",
					Description="The second acount status test in the system."
				},
                new Entities.AccountStatus()
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
