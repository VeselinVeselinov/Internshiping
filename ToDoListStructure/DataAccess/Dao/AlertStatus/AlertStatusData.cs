using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.AlertStatus
{
    class AlertStatusData
    {
        public static List<Entities.AlertStatus> Storage;
        public static IDictionary<long,Entities.AlertStatus> Data;

        static AlertStatusData()
        {
            Data = new Dictionary<long,Entities.AlertStatus>();
            Storage = new List<Entities.AlertStatus>()
            {
                new Entities.AlertStatus()
                {
					Id=1,
                    Code="One",
                    Name="First",
                    Description="First tester"
                },
                new Entities.AlertStatus()
                {
					Id=2,
                    Code="Two",
                    Name="Second",
                    Description="Second tester"
                },
                new Entities.AlertStatus()
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
