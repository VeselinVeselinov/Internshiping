using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.TextNote
{
	class TextNoteData
	{
		public static List<Entities.TextNote> Storage;
		public static IDictionary<long, Entities.TextNote> Data;

		static TextNoteData()
		{
			Data = new Dictionary<long, Entities.TextNote>();
			Storage = new List<Entities.TextNote>()
			{
				new Entities.TextNote()
				{
					Id=1,
					Code="First test text note",
					Name="First",
					Description="This is the first text note test in the system"
				},
				new Entities.TextNote()
				{
					Id=2,
					Code="Second test text note",
					Name="Second",
					Description="This is the second text note test in the system"
				},
				new Entities.TextNote()
				{
					Id=3,
					Code="Third test text note",
					Name="Third",
					Description="This is the third text note test in the system"
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
