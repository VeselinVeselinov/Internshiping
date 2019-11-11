using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.DataAccess.Dao.ListNoteItem
{
    class ListNoteItemDao : IListNoteItemDao
    {
		public void Delete(long id)
		{
			Data.Entity.ListNoteItem entity = Find(id);
			Delete(entity);
		}

		public void Delete(Data.Entity.ListNoteItem entity)
		{
			ListNoteItemData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Data.Entity.ListNoteItem Find(long id)
		{
			return ListNoteItemData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Data.Entity.ListNoteItem> Find()
		{
			return ListNoteItemData.Data.Values.ToList();
		}

		public List<Data.Entity.ListNoteItem> FindByAttribute(string att, string value)
		{
			return ListNoteItemData.Data.Values
								.Where(entity => entity.GetType()
									.GetProperty(att)
										.GetValue(entity, null).ToString()
											.Equals(value))
												.ToList();
		}

		public Data.Entity.ListNoteItem FindByCode(string code)
		{
			return ListNoteItemData.Data.Values
				.Where(entity => entity.Code.Equals(code))
				.Single();
		}

		public List<Data.Entity.ListNoteItem> FindByName(string name)
		{
			return ListNoteItemData.Data.Values
				.Where(entity => entity.Name.Equals(name))
				.ToList();
		}

		public Data.Entity.ListNoteItem Save(Data.Entity.ListNoteItem entity)
		{
			ListNoteItemData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Data.Entity.ListNoteItem> Save(List<Data.Entity.ListNoteItem> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Data.Entity.ListNoteItem Update(Data.Entity.ListNoteItem entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Data.Entity.ListNoteItem> Update(List<Data.Entity.ListNoteItem> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
}
