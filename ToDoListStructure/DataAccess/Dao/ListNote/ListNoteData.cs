using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ListNote
{
    class ListNoteData
    {
        public static List<Entities.ListNote> Storage;
        public static IDictionary<long, Entities.ListNote> Data;

        static ListNoteData()
        {
            Data = new Dictionary<long, Entities.ListNote>();
            Storage = new List<Entities.ListNote>()
            {
                new Entities.ListNote()
                {
					Id=1,
                    Code="One",
                    Name="First",
                    Description="First tester",
                    Content=null,
                    Color=Color.Green,
                    Account=null,
                    Category=null,
                    Status=null,
                    TextSize=12
                },
                new Entities.ListNote()
                {
					Id=2,
                    Code="Two",
                    Name="Second",
                    Description="Second tester",
                    Content=null,
                    Color=Color.Green,
                    Account=null,
                    Category=null,
                    Status=null,
                    TextSize=12
                },
                new Entities.ListNote()
                {
					Id=3,
                    Code="Three",
                    Name="Third",
                    Description="Third tester",
                    Content=null,
                    Color=Color.Green,
                    Account=null,
                    Category=null,
                    Status=null,
                    TextSize=12
                }
            };
            Storage.ForEach(entity => Data.Add(entity.Id, entity));
        }
    }
}
