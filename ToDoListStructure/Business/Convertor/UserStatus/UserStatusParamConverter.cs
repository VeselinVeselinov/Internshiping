using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.DataAccess.Dao.UserStatus;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.UserStatus
{
    class UserStatusParamConverter:BaseParamConverter<UserStatusParam, Data.Entity.UserStatus>,IUserStatusParamConverter
    {
		public override Data.Entity.UserStatus ConvertSpecific(UserStatusParam param, Data.Entity.UserStatus entity)
		{
			throw new NotImplementedException();
		}

		public Data.Entity.UserStatus Convert(UserStatusParam param, Data.Entity.UserStatus oldEntity)
        {
			Data.Entity.UserStatus entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Data.Entity.UserStatus()
				{
					Id=param.Id,
					Code=param.Code
				};
			}

			entity.Name = param.Name;
			entity.Description = param.Description;

			return entity;
		}
	}
}
