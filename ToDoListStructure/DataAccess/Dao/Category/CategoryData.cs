using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Category
{
    class CategoryData
    {
        public static List<Entities.Category> Storage;
        public static IDictionary<long, Entities.Category> Data;

        static CategoryData()
        {
            Data = new Dictionary<long, Entities.Category>();
            Storage = new List<Entities.Category>()
            {
                new Entities.Category()
                {
					Id=1,
                    Code="One",
                    Name="First",
                    Description="First tester"
                },
                new Entities.Category()
                {
					Id=2,
                    Code="Two",
                    Name="Second",
                    Description="Second tester"
                },
                new Entities.Category()
                {
					Id=3,
                    Code="Three",
                    Name="Third",
                    Description="Third tester"
                }
            };
            Storage.ForEach(entity => Data.Add(entity.Id, entity));
        }
    }
}
