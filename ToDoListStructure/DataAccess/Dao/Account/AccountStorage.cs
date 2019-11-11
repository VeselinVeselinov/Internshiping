using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.DataAccess.Dao.AccountStatus;
using ToDoListStructure.DataAccess.Dao.User;

namespace ToDoListStructure.DataAccess.Dao.Account
{
    class AccountData
    {
        public static List<Data.Entity.Account> Storage;
        public static IDictionary<long, Data.Entity.Account> Data;

        static AccountData()
        {
            Data= new Dictionary<long, Data.Entity.Account>();
            Storage = new List<Data.Entity.Account>()
            {
				new Data.Entity.Account()
				{
					Id=1,
					Code="FirstAcc",
					Name="First account",
					Description="This is the first test account in the system",
					FirstName="Account",
					LastName="The First",
					Address="Drujba 1 - Plovdiv",
					Phone="+35912345687",
					Email="test1@abv.bg",
					User=UserData.Data.Where(user=>user.Key.Equals(1)).Single().Value,
					Status=AccountStatusData.Data.Where(status=>status.Key.Equals(1)).Single().Value
				},
				new Data.Entity.Account
				{
					Id=2,
					Code="SecondAcc",
					Name="Second account",
					Description="This is the second test account in the system",
					FirstName="Account",
					LastName="The Second",
					Address="Drujba 1 - Plovdiv",
					Phone="+35966345687",
					Email="test2@abv.bg",
					User=UserData.Data.Where(user=>user.Key.Equals(2)).Single().Value,
					Status=AccountStatusData.Data.Where(status=>status.Key.Equals(2)).Single().Value
				},
				new Data.Entity.Account
				{
					Id=3,
					Code="ThirdAcc",
					Name="Third account",
					Description="This is the third test account in the system",
					FirstName="Account",
					LastName="The Third",
					Address="Drujba 1 - Plovdiv",
					Phone="+35916975687",
					Email="test3@abv.bg",
					User=UserData.Data.Where(user=>user.Key.Equals(3)).Single().Value,
					Status=AccountStatusData.Data.Where(status=>status.Key.Equals(3)).Single().Value
				}
			};
            Storage.ForEach(entity => Data.Add(entity.Id, entity));
        }
    }
}
