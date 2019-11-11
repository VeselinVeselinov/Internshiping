using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.DataAccess.Dao.ShareStatus
{
    class ShareStatusDao : IShareStatusDao
    {
		public void Delete(long id)
		{
			Data.Entity.ShareStatus entity = Find(id);
			Delete(entity);
		}

		public void Delete(Data.Entity.ShareStatus entity)
		{
			ShareStatusData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Data.Entity.ShareStatus Find(long id)
		{
			return ShareStatusData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Data.Entity.ShareStatus> Find()
		{
			return ShareStatusData.Data.Values.ToList();
		}

		public List<Data.Entity.ShareStatus> FindByAttribute(string att, string value)
		{
			return ShareStatusData.Data.Values
								.Where(entity => entity.GetType()
									.GetProperty(att)
										.GetValue(entity, null).ToString()
											.Equals(value))
												.ToList();
		}

		public Data.Entity.ShareStatus FindByCode(string code)
		{
			return ShareStatusData.Data.Values
				.Where(entity => entity.Code.Equals(code))
				.Single();
		}

		public List<Data.Entity.ShareStatus> FindByName(string name)
		{
			return ShareStatusData.Data.Values
				.Where(entity => entity.Name.Equals(name))
				.ToList();
		}

		public Data.Entity.ShareStatus Save(Data.Entity.ShareStatus entity)
		{
			ShareStatusData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Data.Entity.ShareStatus> Save(List<Data.Entity.ShareStatus> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Data.Entity.ShareStatus Update(Data.Entity.ShareStatus entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Data.Entity.ShareStatus> Update(List<Data.Entity.ShareStatus> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
}
