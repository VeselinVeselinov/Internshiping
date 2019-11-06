using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Alert
{
    class AlertDao:IAlertDao
    {
<<<<<<< Updated upstream
=======
        public void Delete(long id)
        {
            Entities.Alert entity = Find(id);
            Delete(entity);
        }

        public void Delete(Entities.Alert entity)
        {
            AlertData.Data.Remove(entity.Id);
        }

        public void Delete(List<long> ids)
        {
            ids.ForEach(id => Delete(id));
        }

        public Entities.Alert Find(long id)
        {
            return AlertData.Data.Values
                    .Where(entity => entity.Id.Equals(id))
                    .Single();
        }

        public List<Entities.Alert> Find()
        {
            return AlertData.Data.Values.ToList();
        }

        public Entities.Alert FindByCode(string code)
        {
            return AlertData.Data.Values
                .Where(entity => entity.Code.Equals(code))
                .Single();
        }

        public List<Entities.Alert> FindByName(string name)
        {
            return AlertData.Data.Values
                .Where(entity => entity.Name.Equals(name))
                .ToList();
        }

        public Entities.Alert Save(Entities.Alert entity)
        {
            AlertData.Data.Add(entity.Id, entity);
            return entity;
        }

        public List<Entities.Alert> Save(List<Entities.Alert> entity)
        {
            entity.ForEach(element=>Save(element));
            return entity;
        }

        public Entities.Alert Update(Entities.Alert entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Entities.Alert> Update(List<Entities.Alert> entity)
        {
            entity.ForEach(element=>Update(element));
            return entity;
        }
>>>>>>> Stashed changes
    }
}
