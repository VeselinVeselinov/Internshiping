using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.DataAccess.Dao.ShareStatus;
using ToDoListStructure.DataAccess.Dao.User;
using ToDoListStructure.DataAccess.Dao.UserStatus;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.User
{
    class UserParamConverter:BaseParamConverter<UserParam,Data.Entity.User>,IUserParamConverter
    {
		IUserStatusDao userStatusDao = new UserStatusDao();

		public override Data.Entity.User ConvertSpecific(UserParam param, Data.Entity.User entity)
		{
			entity.Status = userStatusDao.Find(param.StatusId);

			return entity;
		}

		public Data.Entity.User Convert(UserParam param,Data.Entity.User oldEntity)
        {
			Data.Entity.User entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Data.Entity.User();
			}

			entity.UserName = param.UserName;
			entity.Password = param.Password;
			entity = ConvertSpecific(param,oldEntity);

			return entity;
		}
	}
}
