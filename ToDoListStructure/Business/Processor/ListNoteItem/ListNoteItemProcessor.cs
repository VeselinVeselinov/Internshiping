using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ListNoteItem;
using ToDoListStructure.DataAccess.Dao.ListNoteItem;

namespace ToDoListStructure.Business.Processor.ListNoteItem
{
    class ListNoteItemProcessor:IListNoteItemProcessor
    {
		public IListNoteItemDao Dao = new ListNoteItemDao();

		public IListNoteItemParamConverter ParamConverter = new ListNoteItemParamConverter();

		public IListNoteItemResultConverter ResultConverter = new ListNoteItemResultConverter();

		public ListNoteItemResult Create(ListNoteItemParam param)
		{
			Data.Entity.ListNoteItem entity = ParamConverter.Convert(param,null);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<ListNoteItemResult> Create(List<ListNoteItemParam> param)
		{
			List<Data.Entity.ListNoteItem> entities = new List<Data.Entity.ListNoteItem>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item,null));
			}
			Dao.Save(entities);
			List<ListNoteItemResult> result = new List<ListNoteItemResult>();
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

		public ListNoteItemResult Find(long id)
		{
			Data.Entity.ListNoteItem entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<ListNoteItemResult> Find()
		{
			List<Data.Entity.ListNoteItem> entities = Dao.Find();
			List<ListNoteItemResult> results = new List<ListNoteItemResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public List<ListNoteItemResult> FindByAttribute(string att, string value)
		{
			List<Data.Entity.ListNoteItem> entities = Dao.FindByAttribute(att, value);
			List<ListNoteItemResult> result = new List<ListNoteItemResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public ListNoteItemResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<ListNoteItemResult> FindByName(string name)
		{
			List<Data.Entity.ListNoteItem> entities = Dao.FindByName(name);
			List<ListNoteItemResult> result = new List<ListNoteItemResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, ListNoteItemParam param)
		{
			Data.Entity.ListNoteItem oldEntity = Dao.Find(id);
			Data.Entity.ListNoteItem newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<ListNoteItemParam> param)
		{
			List<Data.Entity.ListNoteItem> entity = new List<Data.Entity.ListNoteItem>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item,Dao.Find(item.Id))));
			Dao.Update(entity);
		}
	}
}
