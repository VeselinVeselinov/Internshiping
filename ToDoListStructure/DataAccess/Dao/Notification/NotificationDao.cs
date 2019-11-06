using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Entities;

namespace ToDoListStructure.DataAccess.Dao.Notification
{
<<<<<<< Updated upstream
    interface NotificationDao:INotificationDeo
    {
    }
=======
	class NotificationDao : INotificationDao
	{
		public void Delete(long id)
		{
			Entities.Notification entity = Find(id);
			Delete(entity);
		}

		public void Delete(Entities.Notification entity)
		{
			NotificationData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Entities.Notification Find(long id)
		{
			return NotificationData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Entities.Notification> Find()
		{
			return NotificationData.Data.Values.ToList();
		}

		public Entities.Notification FindByCode(string code)
		{
			return NotificationData.Data.Values
				.Where(entity => entity.Code.Equals(code))
				.Single();
		}

		public List<Entities.Notification> FindByName(string name)
		{
			return NotificationData.Data.Values
				.Where(entity => entity.Name.Equals(name))
				.ToList();
		}

		public Entities.Notification Save(Entities.Notification entity)
		{
			NotificationData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Entities.Notification> Save(List<Entities.Notification> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Entities.Notification Update(Entities.Notification entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Entities.Notification> Update(List<Entities.Notification> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
>>>>>>> Stashed changes
}
