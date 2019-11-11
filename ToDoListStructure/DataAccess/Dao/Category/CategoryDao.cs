using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.DataAccess.Dao.Category
{
    class CategoryDao : ICategoryDao
    {
		public void Delete(long id)
		{
			Data.Entity.Category entity = Find(id);
			Delete(entity);
		}

		public void Delete(Data.Entity.Category entity)
		{
			CategoryData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Data.Entity.Category Find(long id)
		{
			return CategoryData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Data.Entity.Category> Find()
		{
			return CategoryData.Data.Values.ToList();
		}

		public List<Data.Entity.Category> FindByAttribute(string att, string value)
		{
			return CategoryData.Data.Values
								.Where(entity => entity.GetType()
									.GetProperty(att)
										.GetValue(entity, null).ToString()
											.Equals(value))
												.ToList();
		}

		public Data.Entity.Category FindByCode(string code)
		{
			return CategoryData.Data.Values
				.Where(entity => entity.Code.Equals(code))
				.Single();
		}

		public List<Data.Entity.Category> FindByName(string name)
		{
			return CategoryData.Data.Values
				.Where(entity => entity.Name.Equals(name))
				.ToList();
		}

		public Data.Entity.Category Save(Data.Entity.Category entity)
		{
			CategoryData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Data.Entity.Category> Save(List<Data.Entity.Category> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Data.Entity.Category Update(Data.Entity.Category entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Data.Entity.Category> Update(List<Data.Entity.Category> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
}
