using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.ShareStaus
{
    class ShareStatusProcessor:IShareStatusProcessor
    {
<<<<<<< Updated upstream
    }
=======
		public IShareStatusDao Dao = new ShareStatusDao();

		public IShareStatusParamConverter ParamConverter = new ShareStatusParamConverter();

		public IShareStatusResultConverter ResultConverter = new ShareStatusResultConverter();

		public ShareStatusResult Create(ShareStatusParam param)
		{
			Entities.ShareStatus entity = ParamConverter.Convert(param);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<ShareStatusResult> Create(List<ShareStatusParam> param)
		{
			List<Entities.ShareStatus> entities = new List<Entities.ShareStatus>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item));
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
			Entities.ShareStatus entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<ShareStatusResult> Find()
		{
			List<Entities.ShareStatus> entities = Dao.Find();
			List<ShareStatusResult> results = new List<ShareStatusResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public ShareStatusResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<ShareStatusResult> FindByName(string name)
		{
			List<Entities.ShareStatus> entities = Dao.FindByName(name);
			List<ShareStatusResult> result = new List<ShareStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, ShareStatusParam param)
		{
			Entities.ShareStatus oldEntity = Dao.Find(id);
			Entities.ShareStatus newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<ShareStatusParam> param)
		{
			List<Entities.ShareStatus> entity = new List<Entities.ShareStatus>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
			Dao.Update(entity);
		}
	}
>>>>>>> Stashed changes
}
