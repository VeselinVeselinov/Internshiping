using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.DataAccess.Dao.AlertStatus
{
    class AlertStatusDao : IAlertStatusDao
    {
		public void Delete(long id)
		{
			Data.Entity.AlertStatus entity = Find(id);
			Delete(entity);
		}

		public void Delete(Data.Entity.AlertStatus entity)
		{
			AlertStatusData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Data.Entity.AlertStatus Find(long id)
		{
			return AlertStatusData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Data.Entity.AlertStatus> Find()
		{
			return AlertStatusData.Data.Values.ToList();
		}

		public List<Data.Entity.AlertStatus> FindByAttribute(string att, string value)
		{
			return AlertStatusData.Data.Values
								.Where(entity => entity.GetType()
									.GetProperty(att)
										.GetValue(entity, null).ToString()
											.Equals(value))
												.ToList();
		}

		public Data.Entity.AlertStatus FindByCode(string code)
		{
			return AlertStatusData.Data.Values
				.Where(entity => entity.Code.Equals(code))
				.Single();
		}

		public List<Data.Entity.AlertStatus> FindByName(string name)
		{
			return AlertStatusData.Data.Values
				.Where(entity => entity.Name.Equals(name))
				.ToList();
		}

		public Data.Entity.AlertStatus Save(Data.Entity.AlertStatus entity)
		{
			AlertStatusData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Data.Entity.AlertStatus> Save(List<Data.Entity.AlertStatus> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Data.Entity.AlertStatus Update(Data.Entity.AlertStatus entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Data.Entity.AlertStatus> Update(List<Data.Entity.AlertStatus> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
}
