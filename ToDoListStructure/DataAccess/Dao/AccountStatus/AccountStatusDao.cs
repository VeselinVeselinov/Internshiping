using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.AccountStatus
{
    class AccountStatusDao:IAccountStatusDao
    {
<<<<<<< Updated upstream
=======
        public void Delete(long id)
        {
            Entities.AccountStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Entities.AccountStatus entity)
        {
            AccountStatusData.Data.Remove(entity.Id);

            //AccountStatusData.Storage.Remove(entity);
        }

        public void Delete(List<long> ids)
        {
            ids.ForEach(id => Delete(id));
        }

        public Entities.AccountStatus Find(long id)
        {
            return AccountStatusData.Data
                .Where(element => element.Key.Equals(id))
                .Single()
                .Value;

            //return AccounStatustData.Storage
            //    .Where(entity => entity.ID.Equals(id))
            //    .Single();
        }

        public List<Entities.AccountStatus> Find()
        {
            return AccountStatusData.Data.Values.ToList();

            //return AccountStatusData.Storage;
        }

        public Entities.AccountStatus FindByCode(string code)
        {
            return AccountStatusData.Data.Values
                .Where(element => element.Code.Equals(code))
                .Single();

            //return AccountStatusData.Storage
            //    .Where(entity => entity.Code.Equals(code))
            //    .Single();
        }

        public List<Entities.AccountStatus> FindByName(string name)
        {
            return AccountStatusData.Data.Values
                .Where(entity => entity.Name.Equals(name))
                .ToList();

            //return AccountStatusData.Storage
            //    .Where(entity => entity.Name.Equals(name)).ToList();
        }

        public Entities.AccountStatus Save(Entities.AccountStatus entity)
        {
            AccountStatusData.Data.Add(entity.Id, entity);
            //AccountStatusData.Storage.Add(entity);
            return entity;
        }

        public List<Entities.AccountStatus> Save(List<Entities.AccountStatus> entity)
        {
            entity.ForEach(item => Save(item));
            return entity;
        }

        public Entities.AccountStatus Update(Entities.AccountStatus entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Entities.AccountStatus> Update(List<Entities.AccountStatus> entity)
        {
            entity.ForEach(item => Update(item));
            return entity;
        }
>>>>>>> Stashed changes
    }
}
