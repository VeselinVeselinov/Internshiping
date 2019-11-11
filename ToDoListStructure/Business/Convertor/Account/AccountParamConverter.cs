using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.Account;
using Newtonsoft.Json;
using ToDoListStructure.DataAccess.Dao.User;
using ToDoListStructure.DataAccess.Dao.AccountStatus;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Account
{
    class AccountParamConverter: BaseParamConverter<AccountParam, Data.Entity.Account>, IAccountParamConverter
    {
		private IUserDao userDao = new UserDao();

		private IAccountStatusDao accountStatusDao = new AccountStatusDao();

		public override Data.Entity.Account ConvertSpecific(AccountParam param, Data.Entity.Account entity)
		{
			entity.User = userDao.Find(param.UserId);
			entity.Status = accountStatusDao.Find(param.StatusId);

			if (entity.Status==null||entity.User==null)
			{
				throw new InvalidOperationException();
			}

			return entity;
		}

		public Data.Entity.Account Convert(AccountParam param, Data.Entity.Account oldentity)
		{
			Data.Entity.Account entity = null;

			if (oldentity != null)
			{
				entity = oldentity;
			}
			else
			{
				entity = new Data.Entity.Account()
				{
					Id = param.Id,
					Code = param.Code
				};
			}

			entity = ConvertStandart(param,entity);
			entity = ConvertSpecific(param,entity);

			return entity;
		}
	}
}
