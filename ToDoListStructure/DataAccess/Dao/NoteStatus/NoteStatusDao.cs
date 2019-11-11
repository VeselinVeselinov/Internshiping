using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.DataAccess.Dao.NoteStatus
{
    class NoteStatusDao : INoteStatusDao
    {
		public void Delete(long id)
		{
			Data.Entity.NoteStatus entity = Find(id);
			Delete(entity);
		}

		public void Delete(Data.Entity.NoteStatus entity)
		{
			NoteStatusData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Data.Entity.NoteStatus Find(long id)
		{
			return NoteStatusData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Data.Entity.NoteStatus> Find()
		{
			return NoteStatusData.Data.Values.ToList();
		}

		public List<Data.Entity.NoteStatus> FindByAttribute(string att, string value)
		{
			return NoteStatusData.Data.Values
								.Where(entity => entity.GetType()
									.GetProperty(att)
										.GetValue(entity, null).ToString()
											.Equals(value))
												.ToList();
		}

		public Data.Entity.NoteStatus FindByCode(string code)
		{
			return NoteStatusData.Data.Values
				.Where(entity => entity.Code.Equals(code))
				.Single();
		}

		public List<Data.Entity.NoteStatus> FindByName(string name)
		{
			return NoteStatusData.Data.Values
				.Where(entity => entity.Name.Equals(name))
				.ToList();
		}

		public Data.Entity.NoteStatus Save(Data.Entity.NoteStatus entity)
		{
			NoteStatusData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Data.Entity.NoteStatus> Save(List<Data.Entity.NoteStatus> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Data.Entity.NoteStatus Update(Data.Entity.NoteStatus entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Data.Entity.NoteStatus> Update(List<Data.Entity.NoteStatus> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
}
