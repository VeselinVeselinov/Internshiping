using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.DataAccess.Dao.Account;
using ToDoListStructure.DataAccess.Dao.ShareStatus;

namespace ToDoListStructure.DataAccess.Dao.Share
{
	class ShareData
	{
		public static List<Data.Entity.Share> Storage;
		public static IDictionary<long, Data.Entity.Share> Data;

		static ShareData()
		{
			Data = new Dictionary<long, Data.Entity.Share>();
			Storage = new List<Data.Entity.Share>()
			{
				new Data.Entity.Share()
				{
					Id=1,
					Owner=AccountData.Data.Where(acc=>acc.Key.Equals(1)).Single().Value,
					Contributor=AccountData.Data.Where(acc=>acc.Key.Equals(2)).Single().Value,
					Note=null,
					Status=ShareStatusData.Data.Where(status=>status.Equals(1)).Single().Value

				},
				new Data.Entity.Share()
				{
					Id=2,
					Owner=AccountData.Data.Where(acc=>acc.Key.Equals(2)).Single().Value,
					Contributor=AccountData.Data.Where(acc=>acc.Key.Equals(1)).Single().Value,
					Note=null,
					Status=ShareStatusData.Data.Where(status=>status.Equals(2)).Single().Value
				},
				new Data.Entity.Share()
				{
					Id=3,
					Owner=AccountData.Data.Where(acc=>acc.Key.Equals(3)).Single().Value,
					Contributor=AccountData.Data.Where(acc=>acc.Key.Equals(1)).Single().Value,
					Note=null,
					Status=ShareStatusData.Data.Where(status=>status.Equals(3)).Single().Value
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
