using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.AlertStatus
{
    class AlertStatusDao:IAlertStatusDao
    {
<<<<<<< Updated upstream
=======
        public void Delete(long id)
        {
            Entities.AlertStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Entities.AlertStatus entity)
        {
            AlertStatusData.Data.Remove(entity.Id);
        }

        public void Delete(List<long> ids)
        {
            ids.ForEach(id => Delete(id));
        }

        public Entities.AlertStatus Find(long id)
        {
            return AlertStatusData.Data.Values
                    .Where(entity => entity.Id.Equals(id))
                    .Single();
        }

        public List<Entities.AlertStatus> Find()
        {
            return AlertStatusData.Data.Values.ToList();
        }

        public Entities.AlertStatus FindByCode(string code)
        {
            return AlertStatusData.Data.Values
                .Where(entity => entity.Code.Equals(code))
                .Single();
        }

        public List<Entities.AlertStatus> FindByName(string name)
        {
            return AlertStatusData.Data.Values
                .Where(entity => entity.Name.Equals(name))
                .ToList();
        }

        public Entities.AlertStatus Save(Entities.AlertStatus entity)
        {
            AlertStatusData.Data.Add(entity.Id, entity);
            return entity;
        }

        public List<Entities.AlertStatus> Save(List<Entities.AlertStatus> entity)
        {
            entity.ForEach(element => Save(element));
            return entity;
        }

        public Entities.AlertStatus Update(Entities.AlertStatus entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Entities.AlertStatus> Update(List<Entities.AlertStatus> entity)
        {
            entity.ForEach(element => Update(element));
            return entity;
        }
>>>>>>> Stashed changes
    }
}
