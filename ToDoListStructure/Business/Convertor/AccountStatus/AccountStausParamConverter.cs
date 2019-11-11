using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Account;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.DataAccess.Dao.AccountStatus;

namespace ToDoListStructure.Business.Convertor.AccountStatus
{
    class AccountStausParamConverter: BaseParamConverter<AccountStatusParam, Data.Entity.AccountStatus>, IAccountStatusParamConverter
	{
		public override Data.Entity.AccountStatus ConvertSpecific(AccountStatusParam param, Data.Entity.AccountStatus entity)
		{
			throw new NotImplementedException();
		}

		public Data.Entity.AccountStatus Convert(AccountStatusParam param, Data.Entity.AccountStatus oldEntity)
        {
			Data.Entity.AccountStatus entity = null;

            if (oldEntity!=null)
            {
                entity = oldEntity;
            }
            else
            {
				entity = new Data.Entity.AccountStatus()
				{
					Id = param.Id,
					Code=param.Code
				};
            }

            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
	}
}
