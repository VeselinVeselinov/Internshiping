using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.NoteStatus
{
	class NoteStatusData
	{
		public static List<Data.Entity.NoteStatus> Storage;
		public static IDictionary<long, Data.Entity.NoteStatus> Data;

		static NoteStatusData()
		{
			Data = new Dictionary<long, Data.Entity.NoteStatus>();
			Storage = new List<Data.Entity.NoteStatus>()
			{
				new Data.Entity.NoteStatus()
				{
					Id=1,
					Code="NoteStatus1",
					Name="First",
					Description="First tester note status on the system.",
				},
				new Data.Entity.NoteStatus()
				{
					Id=2,
					Code="NoteStatus2",
					Name="Second",
					Description="Second tester note status on the system.",
				},
				new Data.Entity.NoteStatus()
				{
					Id=3,
					Code="NoteStatus3",
					Name="Third",
					Description="Third tester note status on the system.",
				}
			};
			Storage.ForEach(entity => Data.Add(entity.Id, entity));
		}
	}
}
