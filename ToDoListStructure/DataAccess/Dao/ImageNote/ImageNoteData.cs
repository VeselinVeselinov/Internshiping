using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ImageNote
{
    class ImageNoteData
    {
        public static List<Entities.ImageNote> Storage;
        public static IDictionary<long, Entities.ImageNote> Data;

        static ImageNoteData()
        {
            Data = new Dictionary<long, Entities.ImageNote>();
            Storage = new List<Entities.ImageNote>()
            {
                new Entities.ImageNote()
                {
					Id=1,
                    Code="One",
                    Name="First",
                    Description="First tester",
                    Url="www.google.com",
                    Text="No content in the test note",
                    Color=Color.Green,
                    Account=null,
                    Category=null,
                    Status=null,
                    TextSize=12
                },
                new Entities.ImageNote()
                {
					Id=2,
                    Code="Two",
                    Name="Second",
                    Description="Second tester",
                    Url="www.google.com",
                    Text="No content in the test note",
                    Color=Color.Green,
                    Account=null,
                    Category=null,
                    Status=null,
                    TextSize=12
                },
                new Entities.ImageNote()
                {
					Id=3,
                    Code="Three",
                    Name="Third",
                    Description="Third tester",
                    Url="www.google.com",
                    Text="No content in the test note",
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
