using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Category;
using ToDoListStructure.DataAccess.Dao.Category;

namespace ToDoListStructure.Business.Processor.Category
{
    class CategoryProcessor:ICategoryProcessor
    {
		public ICategoryDao Dao = new CategoryDao();

		public ICategoryParamConverter ParamConverter = new CategoryParamConverter();

		public ICategoryResultConverter ResultConverter = new CategoryResultConverter();

		public CategoryResult Create(CategoryParam param)
		{
			Data.Entity.Category entity = ParamConverter.Convert(param,null);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<CategoryResult> Create(List<CategoryParam> param)
		{
			List<Data.Entity.Category> entities = new List<Data.Entity.Category>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item,null));
			}
			Dao.Save(entities);
			List<CategoryResult> result = new List<CategoryResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Delete(long id)
		{
			Dao.Delete(id);
		}

		public void Delete(List<long> idList)
		{
			Dao.Delete(idList);
		}

		public CategoryResult Find(long id)
		{
			Data.Entity.Category entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<CategoryResult> Find()
		{
			List<Data.Entity.Category> entities = Dao.Find();
			List<CategoryResult> results = new List<CategoryResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public List<CategoryResult> FindByAttribute(string att, string value)
		{
			List<Data.Entity.Category> entities = Dao.FindByAttribute(att, value);
			List<CategoryResult> result = new List<CategoryResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public CategoryResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<CategoryResult> FindByName(string name)
		{
			List<Data.Entity.Category> entities = Dao.FindByName(name);
			List<CategoryResult> result = new List<CategoryResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, CategoryParam param)
		{
			Data.Entity.Category oldEntity = Dao.Find(id);
			Data.Entity.Category newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<CategoryParam> param)
		{
			List<Data.Entity.Category> entity = new List<Data.Entity.Category>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item,Dao.Find(item.Id))));
			Dao.Update(entity);
		}
	}
}
