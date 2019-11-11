using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.DataAccess.Dao.User
{
    class UserDao : IUserDao
    {
		public void Delete(long id)
		{
			Data.Entity.User entity = Find(id);
			Delete(entity);
		}

		public void Delete(Data.Entity.User entity)
		{
			UserData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public void Delete(List<Data.Entity.User> entity)
		{
			throw new NotImplementedException();
		}

		public Data.Entity.User Find(long id)
		{
			if (!UserData.Data.ContainsKey(id))
			{
				return null;
			}
			else return UserData.Data.Values
										.Where(entity => entity.Id.Equals(id))
											.Single();
		}

		public List<Data.Entity.User> Find()
		{
			return UserData.Data.Values.ToList();
		}

		public Data.Entity.User Save(Data.Entity.User entity)
		{
			UserData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Data.Entity.User> Save(List<Data.Entity.User> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Data.Entity.User Update(Data.Entity.User entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Data.Entity.User> Update(List<Data.Entity.User> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
}
