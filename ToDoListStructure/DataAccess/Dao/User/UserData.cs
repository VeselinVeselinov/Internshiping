using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.DataAccess.Dao.UserStatus;

namespace ToDoListStructure.DataAccess.Dao.User
{
	class UserData
	{
		public static List<Data.Entity.User> Storage;
		public static IDictionary<long, Data.Entity.User> Data;

		static UserData()
		{
			Data = new Dictionary<long, Data.Entity.User>();
			Storage = new List<Data.Entity.User>()
			{
				new Data.Entity.User()
				{
					Id=1,
					UserName="Firster",
					Password="hardpassword1",
					Status=UserStatusData.Data.Where(userStatus=>userStatus.Key.Equals(1)).Single().Value
				},
				new Data.Entity.User()
				{
					Id=2,
					UserName="Seconder",
					Password="hardpassword2",
					Status=UserStatusData.Data.Where(userStatus=>userStatus.Key.Equals(2)).Single().Value
				},
				new Data.Entity.User()
				{
					Id=3,
					UserName="Thirder",
					Password="hardpassword3",
					Status=UserStatusData.Data.Where(userStatus=>userStatus.Key.Equals(3)).Single().Value
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
