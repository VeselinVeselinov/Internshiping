using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.User
{
	class UserData
	{
		public static List<Entities.User> Storage;
		public static IDictionary<long, Entities.User> Data;

		static UserData()
		{
			Data = new Dictionary<long, Entities.User>();
			Storage = new List<Entities.User>()
			{
				new Entities.User()
				{
					Id=1,
					UserName="Firster",
					Password="hardpassword1",
					Status=null
				},
				new Entities.User()
				{
					Id=2,
					UserName="Seconder",
					Password="hardpassword2",
					Status=null
				},
				new Entities.User()
				{
					Id=3,
					UserName="Thirder",
					Password="hardpassword3",
					Status=null
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
