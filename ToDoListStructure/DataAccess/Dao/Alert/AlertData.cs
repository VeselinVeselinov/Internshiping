using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Alert
{
    class AlertData
    {
        public static List<Entities.Alert> Storage;
        public static IDictionary<long, Entities.Alert> Data;

        static AlertData()
        {
            Data = new Dictionary<long,Entities.Alert>();
            Storage = new List<Entities.Alert>()
            {
                new Entities.Alert()
                {
					Id=1,
                    Code="1",
                    Name="First",
                    Description="First test"
                },
                new Entities.Alert()
                {
					Id=2,
                    Code="2",
                    Name="Second",
                    Description="Second test"
                }, 
                new Entities.Alert()
                {
					Id=3,
                    Code="3",
                    Name="Third",
                    Description="Third test"
                }
            };
            Storage.ForEach(entity=>Data.Add(entity.Id, entity));
        }
    }
}
