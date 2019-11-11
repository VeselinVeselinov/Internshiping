using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.DataAccess.Dao.Alert
{
    class AlertDao : IAlertDao
    {
		public void Delete(long id)
		{
			Data.Entity.Alert entity = Find(id);
			Delete(entity);
		}

		public void Delete(Data.Entity.Alert entity)
		{
			AlertData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Data.Entity.Alert Find(long id)
		{
			return AlertData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Data.Entity.Alert> Find()
		{
			return AlertData.Data.Values.ToList();
		}

		public List<Data.Entity.Alert> FindByAttribute(string att, string value)
		{
			return AlertData.Data.Values
								.Where(entity => entity.GetType()
									.GetProperty(att)
										.GetValue(entity, null).ToString()
											.Equals(value))
												.ToList();
		}

		public Data.Entity.Alert FindByCode(string code)
		{
			return AlertData.Data.Values
				.Where(entity => entity.Code.Equals(code))
				.Single();
		}

		public List<Data.Entity.Alert> FindByName(string name)
		{
			return AlertData.Data.Values
				.Where(entity => entity.Name.Equals(name))
				.ToList();
		}

		public Data.Entity.Alert Save(Data.Entity.Alert entity)
		{
			AlertData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Data.Entity.Alert> Save(List<Data.Entity.Alert> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Data.Entity.Alert Update(Data.Entity.Alert entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Data.Entity.Alert> Update(List<Data.Entity.Alert> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
}
