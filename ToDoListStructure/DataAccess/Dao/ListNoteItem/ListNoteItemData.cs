using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ListNoteItem
{
    class ListNoteItemData
    {
        public static List<Entities.ListNoteItem> Storage;
        public static IDictionary<long, Entities.ListNoteItem> Data;

        static ListNoteItemData()
        {
            Data = new Dictionary<long, Entities.ListNoteItem>();
            Storage = new List<Entities.ListNoteItem>()
            {
                new Entities.ListNoteItem()
                {
					Id=1,
                    Code="One",
                    Name="First",
                    Description="First tester",
                    IsChecked=false,
                    Text="No content in this tester"
                },
                new Entities.ListNoteItem()
                {
					Id=2,
                    Code="Two",
                    Name="Second",
                    Description="Second tester",
                    IsChecked=false,
                    Text="No content in this tester"
                },
                new Entities.ListNoteItem()
                {
					Id=3,
                    Code="Three",
                    Name="Third",
                    Description="Third tester",
                    IsChecked=false,
                    Text="No content in this tester"
                }
            };
            Storage.ForEach(entity => Data.Add(entity.Id, entity));
        }
    }
}
