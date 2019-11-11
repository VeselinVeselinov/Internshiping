using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.NotificationStatus;
using ToDoListStructure.DataAccess.Dao.NotificationStatus;

namespace ToDoListStructure.Business.Processor.NotificationStatus
{
    class NotificationStatusProcessor:INotificationStatusProcessor
    {
		public INotificationStatusDao Dao = new NotificationStatusDao();

		public INotificationStatusParamConverter ParamConverter = new NotificationStatusParamConverter();

		public INotificationStatusResultConverter ResultConverter = new NotificationStatusResultConverter();

		public NotificationStatusResult Create(NotificationStatusParam param)
		{
			Data.Entity.NotificationStatus entity = ParamConverter.Convert(param,null);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<NotificationStatusResult> Create(List<NotificationStatusParam> param)
		{
			List<Data.Entity.NotificationStatus> entities = new List<Data.Entity.NotificationStatus>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item,null));
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
			Data.Entity.NotificationStatus entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<NotificationStatusResult> Find()
		{
			List<Data.Entity.NotificationStatus> entities = Dao.Find();
			List<NotificationStatusResult> results = new List<NotificationStatusResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public List<NotificationStatusResult> FindByAttribute(string att, string value)
		{
			List<Data.Entity.NotificationStatus> entities = Dao.FindByAttribute(att, value);
			List<NotificationStatusResult> result = new List<NotificationStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public NotificationStatusResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<NotificationStatusResult> FindByName(string name)
		{
			List<Data.Entity.NotificationStatus> entities = Dao.FindByName(name);
			List<NotificationStatusResult> result = new List<NotificationStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, NotificationStatusParam param)
		{
			Data.Entity.NotificationStatus oldEntity = Dao.Find(id);
			Data.Entity.NotificationStatus newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<NotificationStatusParam> param)
		{
			List<Data.Entity.NotificationStatus> entity = new List<Data.Entity.NotificationStatus>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item,Dao.Find(item.Id))));
			Dao.Update(entity);
		}
	}
}
