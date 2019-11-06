using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.Notification
{
    class NotificationProcessor:INotificationProcessor
    {
<<<<<<< Updated upstream
    }
=======
		public INotificationDao Dao = new NotificationDao();

		public INotificationParamConverter ParamConverter = new NotificationParamConverter();

		public INotificationResultConverter ResultConverter = new NotificationResultConverter();

		public NotificationResult Create(NotificationParam param)
		{
			Entities.Notification entity = ParamConverter.Convert(param);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<NotificationResult> Create(List<NotificationParam> param)
		{
			List<Entities.Notification> entities = new List<Entities.Notification>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item));
			}
			Dao.Save(entities);
			List<NotificationResult> result = new List<NotificationResult>();
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

		public NotificationResult Find(long id)
		{
			Entities.Notification entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<NotificationResult> Find()
		{
			List<Entities.Notification> entities = Dao.Find();
			List<NotificationResult> results = new List<NotificationResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public NotificationResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<NotificationResult> FindByName(string name)
		{
			List<Entities.Notification> entities = Dao.FindByName(name);
			List<NotificationResult> result = new List<NotificationResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, NotificationParam param)
		{
			Entities.Notification oldEntity = Dao.Find(id);
			Entities.Notification newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<NotificationParam> param)
		{
			List<Entities.Notification> entity = new List<Entities.Notification>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
			Dao.Update(entity);
		}
	}
>>>>>>> Stashed changes
}
