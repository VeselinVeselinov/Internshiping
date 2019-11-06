using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Share
{
	class ShareData
	{
		public static List<Entities.Share> Storage;
		public static IDictionary<long, Entities.Share> Data;

		static ShareData()
		{
			Data = new Dictionary<long, Entities.Share>();
			Storage = new List<Entities.Share>()
			{
				new Entities.Share()
				{
					Id=1,
					Owner=null,
					Contributor=null,
					Note=null,
					Status=null

				},
				new Entities.Share()
				{
					Id=2,
					Owner=null,
					Contributor=null,
					Note=null,
					Status=null
				},
				new Entities.Share()
				{
					Id=3,
					Owner=null,
					Contributor=null,
					Note=null,
					Status=null
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
