using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.UserStatus
{
    class UserStatusProcessor:IUserStatusProcessor
    {
<<<<<<< Updated upstream
    }
=======
		public IUserStatusDao Dao = new UserStatusDao();

		public IUserStatusParamConverter ParamConverter = new UserStatusParamConverter();

		public IUserStatusResultConverter ResultConverter = new UserStatusResultConverter();

		public UserStatusResult Create(UserStatusParam param)
		{
			Entities.UserStatus entity = ParamConverter.Convert(param);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<UserStatusResult> Create(List<UserStatusParam> param)
		{
			List<Entities.UserStatus> entities = new List<Entities.UserStatus>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item));
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
			Entities.UserStatus entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<UserStatusResult> Find()
		{
			List<Entities.UserStatus> entities = Dao.Find();
			List<UserStatusResult> results = new List<UserStatusResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public UserStatusResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<UserStatusResult> FindByName(string name)
		{
			List<Entities.UserStatus> entities = Dao.FindByName(name);
			List<UserStatusResult> result = new List<UserStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, UserStatusParam param)
		{
			Entities.UserStatus oldEntity = Dao.Find(id);
			Entities.UserStatus newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<UserStatusParam> param)
		{
			List<Entities.UserStatus> entity = new List<Entities.UserStatus>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
			Dao.Update(entity);
		}
	}
>>>>>>> Stashed changes
}
