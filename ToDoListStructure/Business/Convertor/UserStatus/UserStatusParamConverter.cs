using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.UserStatus
{
    class UserStatusParamConverter:IUserStatusParamConverter
    {
<<<<<<< Updated upstream
    }
=======
		public IUserStatusDao Dao = new UserStatusDao();

        public Entities.UserStatus Convert(UserStatusParam param)
        {
			Entities.UserStatus entity = new Entities.UserStatus()
			{
				Id = param.Id,
				Code = param.Code,
				Name = param.Name,
				Description = param.Description,
			};
			return entity;
		}

		public Entities.UserStatus Convert(UserStatusParam param, Entities.UserStatus oldEntity)
		{
			Entities.UserStatus entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Entities.UserStatus();
			}

			entity.Name = param.Name;
			entity.Description = param.Description;

			return entity;
		}
	}
>>>>>>> Stashed changes
}
