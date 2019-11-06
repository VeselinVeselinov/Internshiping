using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.NotificationStatus
{
    class NotificationStatusDao:INotificationStatusDao
    {
<<<<<<< Updated upstream
    }
=======
		public void Delete(long id)
		{
			Entities.NotificationStatus entity = Find(id);
			Delete(entity);
		}

		public void Delete(Entities.NotificationStatus entity)
		{
			NotificationStatusData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Entities.NotificationStatus Find(long id)
		{
			return NotificationStatusData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Entities.NotificationStatus> Find()
		{
			return NotificationStatusData.Data.Values.ToList();
		}

		public Entities.NotificationStatus FindByCode(string code)
		{
			return NotificationStatusData.Data.Values
				.Where(entity => entity.Code.Equals(code))
				.Single();
		}

		public List<Entities.NotificationStatus> FindByName(string name)
		{
			return NotificationStatusData.Data.Values
				.Where(entity => entity.Name.Equals(name))
				.ToList();
		}

		public Entities.NotificationStatus Save(Entities.NotificationStatus entity)
		{
			NotificationStatusData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Entities.NotificationStatus> Save(List<Entities.NotificationStatus> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Entities.NotificationStatus Update(Entities.NotificationStatus entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Entities.NotificationStatus> Update(List<Entities.NotificationStatus> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
>>>>>>> Stashed changes
}
