using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Notification;
using ToDoListStructure.DataAccess.Dao.Notification;

namespace ToDoListStructure.Business.Processor.Notification
{
    class NotificationProcessor:INotificationProcessor
    {
		public INotificationDao Dao = new NotificationDao();

		public INotificationParamConverter ParamConverter = new NotificationParamConverter();

		public INotificationResultConverter ResultConverter = new NotificationResultConverter();

		public NotificationResult Create(NotificationParam param)
		{
			Data.Entity.Notification entity = ParamConverter.Convert(param,null);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<NotificationResult> Create(List<NotificationParam> param)
		{
			List<Data.Entity.Notification> entities = new List<Data.Entity.Notification>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item,null));
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
			Data.Entity.Notification entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<NotificationResult> Find()
		{
			List<Data.Entity.Notification> entities = Dao.Find();
			List<NotificationResult> results = new List<NotificationResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public List<NotificationResult> FindByAttribute(string att, string value)
		{
			List<Data.Entity.Notification> entities = Dao.FindByAttribute(att, value);
			List<NotificationResult> result = new List<NotificationResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public NotificationResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<NotificationResult> FindByName(string name)
		{
			List<Data.Entity.Notification> entities = Dao.FindByName(name);
			List<NotificationResult> result = new List<NotificationResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, NotificationParam param)
		{
			Data.Entity.Notification oldEntity = Dao.Find(id);
			Data.Entity.Notification newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<NotificationParam> param)
		{
			List<Data.Entity.Notification> entity = new List<Data.Entity.Notification>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item, Dao.Find(item.Id))));
			Dao.Update(entity);
		}
	}
}
