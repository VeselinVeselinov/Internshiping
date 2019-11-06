using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
<<<<<<< Updated upstream

namespace ToDoListStructure.Business.Convertor.Account
{
    class AccountResultConverter:IAccountResultConverter
    {
    }
=======
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.Account
{
    class AccountResultConverter: BaseResultConverter<Entities.Account, AccountResult>,IAccountResultConverter
    {
		public override AccountResult ConvertSpecific(Entities.Account entity, AccountResult result)
		{
			result.StatusId = entity.Status.Id;
			result.StatusName = entity.Status.Name;
			result.UserId = entity.User.Id;
			result.UserName = entity.User.UserName;
			return result;
		}

		public AccountResult Convert(Entities.Account param)
        {
			AccountResult result = ConvertStandart(param,new AccountResult());
			return ConvertSpecific(param,result);
        }
	}
>>>>>>> Stashed changes
}
