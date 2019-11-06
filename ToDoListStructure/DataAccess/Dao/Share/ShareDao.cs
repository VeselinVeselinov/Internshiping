using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Share
{
    class ShareDao:IShareDao
    {
<<<<<<< Updated upstream
    }
=======
		public void Delete(long id)
		{
			Entities.Share entity = Find(id);
			Delete(entity);
		}

		public void Delete(Entities.Share entity)
		{
			ShareData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Entities.Share Find(long id)
		{
			return ShareData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Entities.Share> Find()
		{
			return ShareData.Data.Values.ToList();
		}

		public Entities.Share Save(Entities.Share entity)
		{
			ShareData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Entities.Share> Save(List<Entities.Share> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Entities.Share Update(Entities.Share entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Entities.Share> Update(List<Entities.Share> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
>>>>>>> Stashed changes
}
