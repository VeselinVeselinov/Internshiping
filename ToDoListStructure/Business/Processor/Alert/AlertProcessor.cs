using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Alert;
using ToDoListStructure.DataAccess.Dao.Alert;

namespace ToDoListStructure.Business.Processor.Alert
{
    class AlertProcessor:IAlertProcessor
    {
		public IAlertDao Dao = new AlertDao();

		public IAlertResultConverter ResultConverter = new AlertResultConverter();

		public IAlertParamConverter ParamConverter = new AlertParamConverter();

		public AlertResult Create(AlertParam param)
		{
			Data.Entity.Alert entity = ParamConverter.Convert(param,null);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<AlertResult> Create(List<AlertParam> param)
		{
			List<Data.Entity.Alert> entities = new List<Data.Entity.Alert>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item,null));
			}
			Dao.Save(entities);
			List<AlertResult> result = new List<AlertResult>();
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

		public AlertResult Find(long id)
		{
			Data.Entity.Alert entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<AlertResult> Find()
		{
			List<Data.Entity.Alert> entities = Dao.Find();
			List<AlertResult> results = new List<AlertResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public List<AlertResult> FindByAttribute(string att, string value)
		{
			List<Data.Entity.Alert> entities = Dao.FindByAttribute(att, value);
			List<AlertResult> result = new List<AlertResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public AlertResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<AlertResult> FindByName(string name)
		{
			List<Data.Entity.Alert> entities = Dao.FindByName(name);
			List<AlertResult> result = new List<AlertResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, AlertParam param)
		{
			Data.Entity.Alert oldEntity = Dao.Find(id);
			Data.Entity.Alert newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<AlertParam> param)
		{
			List<Data.Entity.Alert> entity = new List<Data.Entity.Alert>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item,Dao.Find(item.Id))));
			Dao.Update(entity);
		}
	}
}
