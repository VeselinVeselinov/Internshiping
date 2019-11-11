using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Category
{
	class CategoryData
	{
		public static List<Data.Entity.Category> Storage;
		public static IDictionary<long, Data.Entity.Category> Data;

		static CategoryData()
		{
			Data = new Dictionary<long, Data.Entity.Category>();
			Storage = new List<Data.Entity.Category>()
			{
				new Data.Entity.Category()
				{
					Id=1,
					Code="Catgry1",
					Name="First",
					Description="First tester note category on the system."
				},
				new Data.Entity.Category()
				{
					Id=2,
					Code="Catgry2",
					Name="Second",
					Description="Second tester note category on the system."
				},
				new Data.Entity.Category()
				{
					Id=3,
					Code="Catgry3",
					Name="Third",
					Description="Third tester note category on the system."
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
