using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.User
{
    class UserProcessor:IUserProcessor
    {
<<<<<<< Updated upstream
    }
=======
		public IUserDao Dao = new UserDao();

		public IUserParamConverter ParamConverter = new UserParamConverter();

		public IUserResultConverter ResultConverter = new UserResultConverter();

		public UserResult Create(UserParam param)
		{
			Entities.User entity = ParamConverter.Convert(param);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<UserResult> Create(List<UserParam> param)
		{
			List<Entities.User> entities = new List<Entities.User>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item));
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
			Entities.User entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<UserResult> Find()
		{
			List<Entities.User> entities = Dao.Find();
			List<UserResult> results = new List<UserResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public void Update(long id, UserParam param)
		{
			Entities.User oldEntity = Dao.Find(id);
			Entities.User newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<UserParam> param)
		{
			List<Entities.User> entity = new List<Entities.User>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
			Dao.Update(entity);
		}
	}
>>>>>>> Stashed changes
}
