using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.UserStatus;
using ToDoListStructure.DataAccess.Dao.UserStatus;

namespace ToDoListStructure.Business.Processor.UserStatus
{
    class UserStatusProcessor:IUserStatusProcessor
    {
		public IUserStatusDao Dao = new UserStatusDao();

		public IUserStatusParamConverter ParamConverter = new UserStatusParamConverter();

		public IUserStatusResultConverter ResultConverter = new UserStatusResultConverter();

		public UserStatusResult Create(UserStatusParam param)
		{
			Data.Entity.UserStatus entity = ParamConverter.Convert(param,null);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<UserStatusResult> Create(List<UserStatusParam> param)
		{
			List<Data.Entity.UserStatus> entities = new List<Data.Entity.UserStatus>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item,null));
			}
			Dao.Save(entities);
			List<UserStatusResult> result = new List<UserStatusResult>();
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

		public UserStatusResult Find(long id)
		{
			Data.Entity.UserStatus entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<UserStatusResult> Find()
		{
			List<Data.Entity.UserStatus> entities = Dao.Find();
			List<UserStatusResult> results = new List<UserStatusResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public List<UserStatusResult> FindByAttribute(string att, string value)
		{
			List<Data.Entity.UserStatus> entities = Dao.FindByAttribute(att, value);
			List<UserStatusResult> result = new List<UserStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public UserStatusResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<UserStatusResult> FindByName(string name)
		{
			List<Data.Entity.UserStatus> entities = Dao.FindByName(name);
			List<UserStatusResult> result = new List<UserStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, UserStatusParam param)
		{
			Data.Entity.UserStatus oldEntity = Dao.Find(id);
			Data.Entity.UserStatus newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<UserStatusParam> param)
		{
			List<Data.Entity.UserStatus> entity = new List<Data.Entity.UserStatus>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item,Dao.Find(item.Id))));
			Dao.Update(entity);
		}
	}
}
