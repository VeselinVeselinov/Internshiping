using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ShareStatus;
using ToDoListStructure.DataAccess.Dao.ShareStatus;

namespace ToDoListStructure.Business.Processor.ShareStaus
{
    class ShareStatusProcessor:IShareStatusProcessor
    {
		public IShareStatusDao Dao = new ShareStatusDao();

		public IShareStatusParamConverter ParamConverter = new ShareStatusParamConverter();

		public IShareStatusResultConverter ResultConverter = new ShareStatusResultConverter();

		public ShareStatusResult Create(ShareStatusParam param)
		{
			Data.Entity.ShareStatus entity = ParamConverter.Convert(param,null);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<ShareStatusResult> Create(List<ShareStatusParam> param)
		{
			List<Data.Entity.ShareStatus> entities = new List<Data.Entity.ShareStatus>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item,null));
			}
			Dao.Save(entities);
			List<ShareStatusResult> result = new List<ShareStatusResult>();
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

		public ShareStatusResult Find(long id)
		{
			Data.Entity.ShareStatus entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<ShareStatusResult> Find()
		{
			List<Data.Entity.ShareStatus> entities = Dao.Find();
			List<ShareStatusResult> results = new List<ShareStatusResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public List<ShareStatusResult> FindByAttribute(string att, string value)
		{
			List<Data.Entity.ShareStatus> entities = Dao.FindByAttribute(att, value);
			List<ShareStatusResult> result = new List<ShareStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public ShareStatusResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<ShareStatusResult> FindByName(string name)
		{
			List<Data.Entity.ShareStatus> entities = Dao.FindByName(name);
			List<ShareStatusResult> result = new List<ShareStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, ShareStatusParam param)
		{
			Data.Entity.ShareStatus oldEntity = Dao.Find(id);
			Data.Entity.ShareStatus newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<ShareStatusParam> param)
		{
			List<Data.Entity.ShareStatus> entity = new List<Data.Entity.ShareStatus>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item,Dao.Find(item.Id))));
			Dao.Update(entity);
		}
	}
}
