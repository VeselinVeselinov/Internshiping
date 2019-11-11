using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.AlertStatus;
using ToDoListStructure.DataAccess.Dao.AlertStatus;

namespace ToDoListStructure.Business.Processor.AlertStatus
{
    class AlertStatusProcessor:IAlertStatusProcessor
    {
		public IAlertStatusDao Dao = new AlertStatusDao();

		public IAlertStatusResultConverter ResultConverter = new AlertStatusResultConverter();

		public IAlertStatusParamConverter ParamConverter = new AlertStatusParamConverter();

		public AlertStatusResult Create(AlertStatusParam param)
		{
			Data.Entity.AlertStatus entity = ParamConverter.Convert(param,null);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<AlertStatusResult> Create(List<AlertStatusParam> param)
		{
			List<Data.Entity.AlertStatus> entities = new List<Data.Entity.AlertStatus>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item,null));
			}
			Dao.Save(entities);
			List<AlertStatusResult> result = new List<AlertStatusResult>();
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

		public AlertStatusResult Find(long id)
		{
			Data.Entity.AlertStatus entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<AlertStatusResult> Find()
		{
			List<Data.Entity.AlertStatus> entities = Dao.Find();
			List<AlertStatusResult> results = new List<AlertStatusResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public List<AlertStatusResult> FindByAttribute(string att, string value)
		{
			List<Data.Entity.AlertStatus> entities = Dao.FindByAttribute(att, value);
			List<AlertStatusResult> result = new List<AlertStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public AlertStatusResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<AlertStatusResult> FindByName(string name)
		{
			List<Data.Entity.AlertStatus> entities = Dao.FindByName(name);
			List<AlertStatusResult> result = new List<AlertStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, AlertStatusParam param)
		{
			Data.Entity.AlertStatus oldEntity = Dao.Find(id);
			Data.Entity.AlertStatus newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<AlertStatusParam> param)
		{
			List<Data.Entity.AlertStatus> entity = new List<Data.Entity.AlertStatus>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item,Dao.Find(item.Id))));
			Dao.Update(entity);
		}
	}
}
