using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.DataAccess.Dao.NotificationStatus
{
    class NotificationStatusDao : INotificationStatusDao
    {
		public void Delete(long id)
		{
			Data.Entity.NotificationStatus entity = Find(id);
			Delete(entity);
		}

		public void Delete(Data.Entity.NotificationStatus entity)
		{
			NotificationStatusData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Data.Entity.NotificationStatus Find(long id)
		{
			return NotificationStatusData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Data.Entity.NotificationStatus> Find()
		{
			return NotificationStatusData.Data.Values.ToList();
		}

		public List<Data.Entity.NotificationStatus> FindByAttribute(string att, string value)
		{
			return NotificationStatusData.Data.Values
								.Where(entity => entity.GetType()
									.GetProperty(att)
										.GetValue(entity, null).ToString()
											.Equals(value))
												.ToList();
		}

		public Data.Entity.NotificationStatus FindByCode(string code)
		{
			return NotificationStatusData.Data.Values
				.Where(entity => entity.Code.Equals(code))
				.Single();
		}

		public List<Data.Entity.NotificationStatus> FindByName(string name)
		{
			return NotificationStatusData.Data.Values
				.Where(entity => entity.Name.Equals(name))
				.ToList();
		}

		public Data.Entity.NotificationStatus Save(Data.Entity.NotificationStatus entity)
		{
			NotificationStatusData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Data.Entity.NotificationStatus> Save(List<Data.Entity.NotificationStatus> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Data.Entity.NotificationStatus Update(Data.Entity.NotificationStatus entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Data.Entity.NotificationStatus> Update(List<Data.Entity.NotificationStatus> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
}
