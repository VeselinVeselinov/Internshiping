using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.UserStatus
{
	class UserStatusData
	{
		public static List<Entities.UserStatus> Storage;
		public static IDictionary<long, Entities.UserStatus> Data;

		static UserStatusData()
		{
			Data = new Dictionary<long, Entities.UserStatus>();
			Storage = new List<Entities.UserStatus>()
			{
				new Entities.UserStatus()
				{
					Id=1,
					Code="First",
					Name="Firster",
					Description="The first user status test in the system"
				},
				new Entities.UserStatus()
				{
					Id=2,
					Code="Second",
					Name="Seconder",
					Description="The second user status test in the system"
				},
				new Entities.UserStatus()
				{
					Id=3,
					Code="Third",
					Name="Thirder",
					Description="The third user status test in the system"
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
