using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.NoteStatus
{
    class NoteStatusData
    {
        public static List<Entities.NoteStatus> Storage;
        public static IDictionary<long, Entities.NoteStatus> Data;

        static NoteStatusData()
        {
            Data = new Dictionary<long, Entities.NoteStatus>();
            Storage = new List<Entities.NoteStatus>()
            {
                new Entities.NoteStatus()
                {
					Id=1,
                    Code="One",
                    Name="First",
                    Description="First tester",
                },
                new Entities.NoteStatus()
                {
					Id=2,
                    Code="Two",
                    Name="Second",
                    Description="Second tester",
                },
                new Entities.NoteStatus()
                {
					Id=3,
                    Code="Three",
                    Name="Third",
                    Description="Third tester",
                }
            };
            Storage.ForEach(entity => Data.Add(entity.Id, entity));
        }
    }
}
