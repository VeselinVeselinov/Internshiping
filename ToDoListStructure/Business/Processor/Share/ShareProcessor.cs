using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Share;
using ToDoListStructure.DataAccess.Dao.Share;

namespace ToDoListStructure.Business.Processor.Share
{
    class ShareProcessor:IShareProcessor
    {
		public IShareDao Dao = new ShareDao();

		public IShareParamConverter ParamConverter = new ShareParamConverter();

		public IShareResultConverter ResultConverter = new ShareResultConverter();

		public ShareResult Create(ShareParam param)
		{
			Data.Entity.Share entity = ParamConverter.Convert(param,null);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<ShareResult> Create(List<ShareParam> param)
		{
			List<Data.Entity.Share> entities = new List<Data.Entity.Share>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item,null));
			}
			Dao.Save(entities);
			List<ShareResult> result = new List<ShareResult>();
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

		public ShareResult Find(long id)
		{
			Data.Entity.Share entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<ShareResult> Find()
		{
			List<Data.Entity.Share> entities = Dao.Find();
			List<ShareResult> results = new List<ShareResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public void Update(long id, ShareParam param)
		{
			Data.Entity.Share oldEntity = Dao.Find(id);
			Data.Entity.Share newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<ShareParam> param)
		{
			List<Data.Entity.Share> entity = new List<Data.Entity.Share>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item,Dao.Find(item.Id))));
			Dao.Update(entity);
		}
	}
}
