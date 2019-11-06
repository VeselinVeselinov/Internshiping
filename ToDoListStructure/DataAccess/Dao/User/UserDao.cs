using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.User
{
    class UserDao:IUserDao
    {
<<<<<<< Updated upstream
    }
=======
		public void Delete(long id)
		{
			Entities.User entity = Find(id);
			Delete(entity);
		}

		public void Delete(Entities.User entity)
		{
			UserData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Entities.User Find(long id)
		{
			return UserData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Entities.User> Find()
		{
			return UserData.Data.Values.ToList();
		}

		public Entities.User Save(Entities.User entity)
		{
			UserData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Entities.User> Save(List<Entities.User> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Entities.User Update(Entities.User entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Entities.User> Update(List<Entities.User> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
>>>>>>> Stashed changes
}
