using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.DataAccess.Dao.Share
{
    class ShareDao : IShareDao
    {
		public void Delete(long id)
		{
			Data.Entity.Share entity = Find(id);
			Delete(entity);
		}

		public void Delete(Data.Entity.Share entity)
		{
			ShareData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Data.Entity.Share Find(long id)
		{
			return ShareData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Data.Entity.Share> Find()
		{
			return ShareData.Data.Values.ToList();
		}

		public Data.Entity.Share Save(Data.Entity.Share entity)
		{
			ShareData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Data.Entity.Share> Save(List<Data.Entity.Share> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Data.Entity.Share Update(Data.Entity.Share entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Data.Entity.Share> Update(List<Data.Entity.Share> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
}
