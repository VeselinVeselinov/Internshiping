using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.Share
{
    class ShareProcessor:IShareProcessor
    {
<<<<<<< Updated upstream
    }
=======
		public IShareDao Dao = new ShareDao();

		public IShareParamConverter ParamConverter = new ShareParamConverter();

		public IShareResultConverter ResultConverter = new ShareResultConverter();

		public ShareResult Create(ShareParam param)
		{
			Entities.Share entity = ParamConverter.Convert(param);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<ShareResult> Create(List<ShareParam> param)
		{
			List<Entities.Share> entities = new List<Entities.Share>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item));
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
			Entities.Share entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<ShareResult> Find()
		{
			List<Entities.Share> entities = Dao.Find();
			List<ShareResult> results = new List<ShareResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public void Update(long id, ShareParam param)
		{
			Entities.Share oldEntity = Dao.Find(id);
			Entities.Share newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<ShareParam> param)
		{
			List<Entities.Share> entity = new List<Entities.Share>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
			Dao.Update(entity);
		}
	}
>>>>>>> Stashed changes
}
