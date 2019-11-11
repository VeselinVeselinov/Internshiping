using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Account
{
    class AccountDao : IAccountDao
    {
		public void Delete(long id)
		{
			Data.Entity.Account entity = Find(id);
			Delete(entity);
		}

		public void Delete(Data.Entity.Account entity)
		{
			AccountData.Data.Remove(entity.Id);
			//AccountData.Storage.Remove(entity);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Data.Entity.Account Find(long id)
		{
			if (!AccountData.Data.Keys.Contains(id))
			{
				return null;
			}
			else return AccountData.Data
								.Where(element => element.Key.Equals(id))
									.Single().Value;
		}

		public List<Data.Entity.Account> Find()
		{
			return AccountData.Data.Values.ToList();
			//return AccountData.Storage;
		}

		public List<Data.Entity.Account> FindByAttribute(string att, string value)
		{
			return AccountData.Data.Values
								.Where(entity => entity.GetType()
									.GetProperty(att)
										.GetValue(entity, null).ToString()
											.Equals(value))
												.ToList();
		}

		public Data.Entity.Account FindByCode(string code)
		{
			return AccountData.Data.Values
									.Where(element => element.Code.Equals(code))
										.Single();

			//return AccountData.Storage
			//    .Where(entity => entity.Code.Equals(code))
			//    .Single();
		}

		public List<Data.Entity.Account> FindByName(string name)
		{
			return AccountData.Data.Values
								.Where(entity => entity.Name.Equals(name))
									.ToList();

			//return AccountData.Storage
			//    .Where(entity => entity.Name.Equals(name)).ToList();
		}

		public Data.Entity.Account Save(Data.Entity.Account entity)
		{
			AccountData.Data.Add(entity.Id, entity);
			//AccountData.Storage.Add(entity);
			return entity;
		}

		public List<Data.Entity.Account> Save(List<Data.Entity.Account> entity)
		{
			entity.ForEach(item => Save(item));
			//entity.ForEach(element=> AccountData.Storage.Add(element));
			return entity;
		}

		public Data.Entity.Account Update(Data.Entity.Account entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Data.Entity.Account> Update(List<Data.Entity.Account> entity)
		{
			entity.ForEach(item => Update(item));
			return entity;
		}
	}
}
