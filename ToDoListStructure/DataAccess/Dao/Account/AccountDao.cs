using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Account
{
    class AccountDao:IAccountDao
    {
<<<<<<< Updated upstream
=======
        public void Delete(long id)
        {
            Entities.Account entity = Find(id);
            Delete(entity);
        }

        public void Delete(Entities.Account entity)
        {
            AccountData.Data.Remove(entity.Id);
            //AccountData.Storage.Remove(entity);
        }

        public void Delete(List<long> ids)
        {
            ids.ForEach(id=>Delete(id));
        }

        public Entities.Account Find(long id)
        {
            return AccountData.Data
                .Where(element => element.Key.Equals(id))
                .Single()
                .Value;

            //return AccountData.Storage
            //    .Where(entity => entity.ID.Equals(id))
            //    .Single();
        }

        public List<Entities.Account> Find()
        {
            return AccountData.Data.Values.ToList();
            //return AccountData.Storage;
        }

		public List<Entities.Account> FindByAttribute(string att, string value)
		{
			return AccountData.Data.Values
					.Where(entity => entity.GetType()
					.GetProperty(att)
					.GetValue(entity, null)
					.ToString()
					.Equals(value))
					.ToList();
		}

		public Entities.Account FindByCode(int code)
        {
            return AccountData.Data.Values
                .Where(element => element.Code.Equals(code))
                .Single();

            //return AccountData.Storage
            //    .Where(entity => entity.Code.Equals(code))
            //    .Single();
        }

        public List<Entities.Account> FindByName(string name)
        {
            return AccountData.Data.Values
                .Where(entity => entity.Name.Equals(name))
                .ToList();

            //return AccountData.Storage
            //    .Where(entity => entity.Name.Equals(name)).ToList();
        }

        public Entities.Account Save(Entities.Account entity)
        {
            AccountData.Data.Add(entity.Id,entity);
            //AccountData.Storage.Add(entity);
            return entity;
        }

        public List<Entities.Account> Save(List<Entities.Account> entity)
        {
            entity.ForEach(item => Save(item));
            //entity.ForEach(element=> AccountData.Storage.Add(element));
            return entity;
        }

        public Entities.Account Update(Entities.Account entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Entities.Account> Update(List<Entities.Account> entity)
        {
            entity.ForEach(item=>Update(item));
            return entity;
        }
>>>>>>> Stashed changes
    }
}
