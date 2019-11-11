using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ListNoteItem
{
	class ListNoteItemData
	{
		public static List<Data.Entity.ListNoteItem> Storage;
		public static IDictionary<long, Data.Entity.ListNoteItem> Data;

		static ListNoteItemData()
		{
			Data = new Dictionary<long, Data.Entity.ListNoteItem>();
			Storage = new List<Data.Entity.ListNoteItem>()
			{
				new Data.Entity.ListNoteItem()
				{
					Id=1,
					Code="LNoteItm3",
					Name="First",
					Description="First tester lit note item on the system.",
					IsChecked=false,
					Text="No content in this tester"
				},
				new Data.Entity.ListNoteItem()
				{
					Id=2,
					Code="LNoteItm2",
					Name="Second",
					Description="Second tester list note item on the system.",
					IsChecked=false,
					Text="No content in this tester"
				},
				new Data.Entity.ListNoteItem()
				{
					Id=3,
					Code="LNoteItm3",
					Name="Third",
					Description="Third tester list note item on the system.",
					IsChecked=false,
					Text="No content in this tester"
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
