using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.DataAccess.Dao.UserStatus
{
    class UserStatusDao : IUserStatusDao
    {
		public void Delete(long id)
		{
			Data.Entity.UserStatus entity = Find(id);
			Delete(entity);
		}

		public void Delete(Data.Entity.UserStatus entity)
		{
			UserStatusData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Data.Entity.UserStatus Find(long id)
		{
			return UserStatusData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Data.Entity.UserStatus> Find()
		{
			return UserStatusData.Data.Values.ToList();
		}

		public List<Data.Entity.UserStatus> FindByAttribute(string att, string value)
		{
			return UserStatusData.Data.Values
								.Where(entity => entity.GetType()
									.GetProperty(att)
										.GetValue(entity, null).ToString()
											.Equals(value))
												.ToList();
		}

		public Data.Entity.UserStatus FindByCode(string code)
		{
			return UserStatusData.Data.Values
				.Where(entity => entity.Code.Equals(code))
				.Single();
		}

		public List<Data.Entity.UserStatus> FindByName(string name)
		{
			return UserStatusData.Data.Values
				.Where(entity => entity.Name.Equals(name))
				.ToList();
		}

		public Data.Entity.UserStatus Save(Data.Entity.UserStatus entity)
		{
			UserStatusData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Data.Entity.UserStatus> Save(List<Data.Entity.UserStatus> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Data.Entity.UserStatus Update(Data.Entity.UserStatus entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Data.Entity.UserStatus> Update(List<Data.Entity.UserStatus> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
}
