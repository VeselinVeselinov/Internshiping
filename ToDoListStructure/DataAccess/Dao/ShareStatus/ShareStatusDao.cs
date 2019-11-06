using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ShareStatus
{
    class ShareStatusDao:IShareStatusDao
    {
<<<<<<< Updated upstream
    }
=======
		public void Delete(long id)
		{
			Entities.ShareStatus entity = Find(id);
			Delete(entity);
		}

		public void Delete(Entities.ShareStatus entity)
		{
			ShareStatusData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Entities.ShareStatus Find(long id)
		{
			return ShareStatusData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Entities.ShareStatus> Find()
		{
			return ShareStatusData.Data.Values.ToList();
		}

		public Entities.ShareStatus FindByCode(string code)
		{
			return ShareStatusData.Data.Values
				.Where(entity => entity.Code.Equals(code))
				.Single();
		}

		public List<Entities.ShareStatus> FindByName(string name)
		{
			return ShareStatusData.Data.Values
				.Where(entity => entity.Name.Equals(name))
				.ToList();
		}

		public Entities.ShareStatus Save(Entities.ShareStatus entity)
		{
			ShareStatusData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Entities.ShareStatus> Save(List<Entities.ShareStatus> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Entities.ShareStatus Update(Entities.ShareStatus entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Entities.ShareStatus> Update(List<Entities.ShareStatus> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
>>>>>>> Stashed changes
}
