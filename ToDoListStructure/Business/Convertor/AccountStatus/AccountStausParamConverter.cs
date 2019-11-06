using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.AccountStatus
{
    class AccountStausParamConverter:IAccountStatusParamConverter
    {
<<<<<<< Updated upstream
=======
        public IAccountStatusDao Dao = new AccountStatusDao();

        public Entities.AccountStatus Convert(AccountStatusParam param)
        {
            Entities.AccountStatus entity = new Entities.AccountStatus()
            {
				Id = param.Id,
                Code = param.Code,
                Name=param.Name,
                Description=param.Description
            };
            return entity;
        }

        public Entities.AccountStatus Convert(AccountStatusParam param, Entities.AccountStatus oldEntity)
        {
            Entities.AccountStatus entity = null;

            if (oldEntity!=null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Entities.AccountStatus();
            }

            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
>>>>>>> Stashed changes
    }
}
