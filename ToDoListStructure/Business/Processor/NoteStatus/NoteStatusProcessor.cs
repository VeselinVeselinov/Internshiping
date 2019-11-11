using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.NoteStatus;
using ToDoListStructure.DataAccess.Dao.NoteStatus;

namespace ToDoListStructure.Business.Processor.NoteStatus
{
    class NoteStatusProcessor:INoteStatusProcessor
    {
		public INoteStatusDao Dao = new NoteStatusDao();

		public INoteStatusParamConverter ParamConverter = new NoteStatusParamConverter();

		public INoteStatusResultConverter ResultConverter = new NoteStatusResultConverter();

		public NoteStatusResult Create(NoteStatusParam param)
		{
			Data.Entity.NoteStatus entity = ParamConverter.Convert(param,null);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<NoteStatusResult> Create(List<NoteStatusParam> param)
		{
			List<Data.Entity.NoteStatus> entities = new List<Data.Entity.NoteStatus>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item,null));
			}
			Dao.Save(entities);
			List<NoteStatusResult> result = new List<NoteStatusResult>();
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

		public NoteStatusResult Find(long id)
		{
			Data.Entity.NoteStatus entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<NoteStatusResult> Find()
		{
			List<Data.Entity.NoteStatus> entities = Dao.Find();
			List<NoteStatusResult> results = new List<NoteStatusResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public List<NoteStatusResult> FindByAttribute(string att, string value)
		{
			List<Data.Entity.NoteStatus> entities = Dao.FindByAttribute(att, value);
			List<NoteStatusResult> result = new List<NoteStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public NoteStatusResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<NoteStatusResult> FindByName(string name)
		{
			List<Data.Entity.NoteStatus> entities = Dao.FindByName(name);
			List<NoteStatusResult> result = new List<NoteStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, NoteStatusParam param)
		{
			Data.Entity.NoteStatus oldEntity = Dao.Find(id);
			Data.Entity.NoteStatus newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<NoteStatusParam> param)
		{
			List<Data.Entity.NoteStatus> entity = new List<Data.Entity.NoteStatus>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item,Dao.Find(item.Id))));
			Dao.Update(entity);
		}
	}
}
