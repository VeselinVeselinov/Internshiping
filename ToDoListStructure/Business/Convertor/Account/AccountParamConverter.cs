using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< Updated upstream
=======
using ToDoListStructure.DataAccess.Dao.Account;
using ToDoListStructure.Entities;
using Newtonsoft.Json;
using ToDoListStructure.DataAccess.Dao.User;
using ToDoListStructure.DataAccess.Dao.AccountStatus;
>>>>>>> Stashed changes

namespace ToDoListStructure.Business.Convertor.Account
{
    class AccountParamConverter:IAccountParamConverter
    {
<<<<<<< Updated upstream
=======
        private IUserDao userDao = new UserDao();

		private IAccountStatusDao accountStatusDao = new AccountStatusDao();

        public Entities.Account Convert(AccountParam param, Entities.Account oldentity)
        {
            Entities.Account entity = null;

            if (oldentity!=null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Entities.Account()
				{
					Id=param.Id,
					Code=param.Code
				};
            }

            entity.Name = param.Name;
            entity.Description = param.Description;
            entity.FirstName = param.FirstName;
            entity.LastName = param.LastName;
            entity.Address = param.Address;
            entity.Phone = param.Phone;
            entity.Email = param.Email;
			entity.User = userDao.Find(param.UserId);
			entity.Status = accountStatusDao.Find(param.StatusId);

            return entity;
        }
>>>>>>> Stashed changes
    }
}
