using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.User
{
    class UserParamConverter:IUserParamConverter
    {
<<<<<<< Updated upstream
    }
=======
		public IUserDao Dao = new UserDao();

        public Entities.User Convert(UserParam param)
        {
			Entities.User entity = new Entities.User()
			{
				Id = param.Id,
				UserName=param.UserName,
				Password=param.Password,
				Status=param.Status
			};
			return entity;
		}

		public Entities.User Convert(UserParam param, Entities.User oldEntity)
		{
			Entities.User entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Entities.User();
			}

			entity.UserName = param.UserName;
			entity.Password = param.Password;
			entity.Status = param.Status;

			return entity;
		}
	}
>>>>>>> Stashed changes
}
