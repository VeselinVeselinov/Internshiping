using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.NotificationStatus
{
    class NotificationStatusProcessor:INotificationStatusProcessor
    {
<<<<<<< Updated upstream
    }
=======
		public INotificationStatusDao Dao = new NotificationStatusDao();

		public INotificationStatusParamConverter ParamConverter = new NotificationStatusParamConverter();

		public INotificationStatusResultConverter ResultConverter = new NotificationStatusResultConverter();

		public NotificationStatusResult Create(NotificationStatusParam param)
		{
			Entities.NotificationStatus entity = ParamConverter.Convert(param);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<NotificationStatusResult> Create(List<NotificationStatusParam> param)
		{
			List<Entities.NotificationStatus> entities = new List<Entities.NotificationStatus>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item));
			}
			Dao.Save(entities);
			List<NotificationStatusResult> result = new List<NotificationStatusResult>();
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

		public NotificationStatusResult Find(long id)
		{
			Entities.NotificationStatus entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<NotificationStatusResult> Find()
		{
			List<Entities.NotificationStatus> entities = Dao.Find();
			List<NotificationStatusResult> results = new List<NotificationStatusResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public NotificationStatusResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<NotificationStatusResult> FindByName(string name)
		{
			List<Entities.NotificationStatus> entities = Dao.FindByName(name);
			List<NotificationStatusResult> result = new List<NotificationStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, NotificationStatusParam param)
		{
			Entities.NotificationStatus oldEntity = Dao.Find(id);
			Entities.NotificationStatus newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<NotificationStatusParam> param)
		{
			List<Entities.NotificationStatus> entity = new List<Entities.NotificationStatus>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
			Dao.Update(entity);
		}
	}
>>>>>>> Stashed changes
}
