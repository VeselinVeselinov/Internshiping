using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.DataAccess.Dao.AccountStatus
{
    class AccountStatusDao : IAccountStatusDao
    {
		public void Delete(long id)
		{
			Data.Entity.AccountStatus entity = Find(id);
			Delete(entity);
		}

		public void Delete(Data.Entity.AccountStatus entity)
		{
			AccountStatusData.Data.Remove(entity.Id);

			//AccountStatusData.Storage.Remove(entity);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Data.Entity.AccountStatus Find(long id)
		{
			if (!AccountStatusData.Data.Keys.Contains(id))
			{
				return null;
			}
			else return AccountStatusData.Data
											.Where(element => element.Key.Equals(id))
												.Single()
													.Value;
		}

		public List<Data.Entity.AccountStatus> Find()
		{
			return AccountStatusData.Data.Values.ToList();

			//return AccountStatusData.Storage;
		}

		public List<Data.Entity.AccountStatus> FindByAttribute(string att, string value)
		{
			return AccountStatusData.Data.Values
								.Where(entity => entity.GetType()
									.GetProperty(att)
										.GetValue(entity, null).ToString()
											.Equals(value))
												.ToList();
		}

		public Data.Entity.AccountStatus FindByCode(string code)
		{
			return AccountStatusData.Data.Values
											.Where(element => element.Code.Equals(code))
												.Single();

			//return AccountStatusData.Storage
			//    .Where(entity => entity.Code.Equals(code))
			//    .Single();
		}

		public List<Data.Entity.AccountStatus> FindByName(string name)
		{
			return AccountStatusData.Data.Values
											.Where(entity => entity.Name.Equals(name))
												.ToList();

			//return AccountStatusData.Storage
			//    .Where(entity => entity.Name.Equals(name)).ToList();
		}

		public Data.Entity.AccountStatus Save(Data.Entity.AccountStatus entity)
		{
			AccountStatusData.Data.Add(entity.Id, entity);
			//AccountStatusData.Storage.Add(entity);
			return entity;
		}

		public List<Data.Entity.AccountStatus> Save(List<Data.Entity.AccountStatus> entity)
		{
			entity.ForEach(item => Save(item));
			return entity;
		}

		public Data.Entity.AccountStatus Update(Data.Entity.AccountStatus entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Data.Entity.AccountStatus> Update(List<Data.Entity.AccountStatus> entity)
		{
			entity.ForEach(item => Update(item));
			return entity;
		}
	}
}
