using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.User;
using ToDoListStructure.DataAccess.Dao.User;

namespace ToDoListStructure.Business.Processor.User
{
    class UserProcessor:IUserProcessor
    {
		public IUserDao Dao = new UserDao();

		public IUserParamConverter ParamConverter = new UserParamConverter();

		public IUserResultConverter ResultConverter = new UserResultConverter();

		public UserResult Create(UserParam param)
		{
			Data.Entity.User entity = ParamConverter.Convert(param,null);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<UserResult> Create(List<UserParam> param)
		{
			List<Data.Entity.User> entities = new List<Data.Entity.User>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item,null));
			}
			Dao.Save(entities);
			List<UserResult> result = new List<UserResult>();
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

		public UserResult Find(long id)
		{
			Data.Entity.User entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<UserResult> Find()
		{
			List<Data.Entity.User> entities = Dao.Find();
			List<UserResult> results = new List<UserResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public void Update(long id, UserParam param)
		{
			Data.Entity.User oldEntity = Dao.Find(id);
			Data.Entity.User newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<UserParam> param)
		{
			List<Data.Entity.User> entity = new List<Data.Entity.User>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item,Dao.Find(item.Id))));
			Dao.Update(entity);
		}
	}
}
