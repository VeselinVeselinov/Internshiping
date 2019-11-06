using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.UserStatus
{
    class UserStatusDao:IUserStatusDao
    {
<<<<<<< Updated upstream
    }
=======
		public void Delete(long id)
		{
			Entities.UserStatus entity = Find(id);
			Delete(entity);
		}

		public void Delete(Entities.UserStatus entity)
		{
			UserStatusData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Entities.UserStatus Find(long id)
		{
			return UserStatusData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Entities.UserStatus> Find()
		{
			return UserStatusData.Data.Values.ToList();
		}

		public Entities.UserStatus FindByCode(string code)
		{
			return UserStatusData.Data.Values
				.Where(entity => entity.Code.Equals(code))
				.Single();
		}

		public List<Entities.UserStatus> FindByName(string name)
		{
			return UserStatusData.Data.Values
				.Where(entity => entity.Name.Equals(name))
				.ToList();
		}

		public Entities.UserStatus Save(Entities.UserStatus entity)
		{
			UserStatusData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Entities.UserStatus> Save(List<Entities.UserStatus> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Entities.UserStatus Update(Entities.UserStatus entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Entities.UserStatus> Update(List<Entities.UserStatus> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
>>>>>>> Stashed changes
}
