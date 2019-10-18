using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Entities;

namespace ToDoListStructure.DataAccess.Dao.Account
{
    class AccountDao : IAccountDao
    {
        public void Delete(long id)
        {
            Console.WriteLine($"Entity with this {id} has been deleted.");
        }

        public void Delete(Entities.Account entity)
        {
            Delete(Find(entity.ID));
        }

        public void Delete(List<Entities.Account> entity)
        {
            foreach (var item in entity)
            {
                Delete(item);
            }
        }

        public Entities.Account Find(long id)
        {
            // where acc.id=id
            Entities.Account wanted = new Entities.Account() { ID = id};
            return wanted;
        }

        public List<Entities.Account> Find()
        {
            List<Entities.Account> all = new List<Entities.Account>();
            return all;
        }

        public Entities.Account Save(Entities.Account entity)
        {
            return entity;
        }

        public List<Entities.Account> Save(List<Entities.Account> entity)
        {
            return entity;
        }

        public Entities.Account Update(Entities.Account entity)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Account> Update(List<Entities.Account> entity)
        {
            throw new NotImplementedException();
        }
    }
}
