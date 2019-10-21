using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Entities;

namespace ToDoListStructure.DataAccess.Dao.Account
{
    class AccountDao : IAccountDao
    {
        public void Delete(long id)
        {
            Entities.Account entity = Find(id);
            Delete(entity);
        }

        public void Delete(Entities.Account entity)
        {
            AccountStorage.Storage.Remove(entity);
        }

        public void Delete(List<Entities.Account> entity)
        {
            entity.ForEach(x=>Delete(x));
        }

        public Entities.Account Find(long id)
        {
            return AccountStorage.Storage
                .Where(x => x.ID.Equals(id))
                .Single();
        }

        public List<Entities.Account> Find()
        {
            return AccountStorage.Storage;
        }

        public Entities.Account Save(Entities.Account entity)
        {
            AccountStorage.Storage.Add(entity);
            return entity;
        }

        public List<Entities.Account> Save(List<Entities.Account> entity)
        {
            entity.ForEach(x=>AccountStorage.Storage.Add(x));
            return entity;
        }

        public Entities.Account Update(Entities.Account entity)
        {
            //find convert delete and save ?
            return entity;
        }

        public List<Entities.Account> Update(List<Entities.Account> entity)
        {
            entity.ForEach(x=>Update(x));
            return entity;
        }
    }
}
