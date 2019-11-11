using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.DataAccess.Dao.Notification
{
    class NotificationDao:INotificationDao
    {
		public void Delete(long id)
		{
			Data.Entity.Notification entity = Find(id);
			Delete(entity);
		}

		public void Delete(Data.Entity.Notification entity)
		{
			NotificationData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Data.Entity.Notification Find(long id)
		{
			return NotificationData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Data.Entity.Notification> Find()
		{
			return NotificationData.Data.Values.ToList();
		}

		public List<Data.Entity.Notification> FindByAttribute(string att, string value)
		{
			return NotificationData.Data.Values
								.Where(entity => entity.GetType()
									.GetProperty(att)
										.GetValue(entity, null).ToString()
											.Equals(value))
												.ToList();
		}

		public Data.Entity.Notification FindByCode(string code)
		{
			return NotificationData.Data.Values
				.Where(entity => entity.Code.Equals(code))
				.Single();
		}

		public List<Data.Entity.Notification> FindByName(string name)
		{
			return NotificationData.Data.Values
				.Where(entity => entity.Name.Equals(name))
				.ToList();
		}

		public Data.Entity.Notification Save(Data.Entity.Notification entity)
		{
			NotificationData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Data.Entity.Notification> Save(List<Data.Entity.Notification> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Data.Entity.Notification Update(Data.Entity.Notification entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Data.Entity.Notification> Update(List<Data.Entity.Notification> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
}
