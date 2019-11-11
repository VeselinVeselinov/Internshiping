using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Account
{
	class AccountResultConverter : BaseResultConverter<Data.Entity.Account, AccountResult>, IAccountResultConverter
	{
		public override AccountResult ConvertSpecific(Data.Entity.Account entity, AccountResult result)
		{
			result.StatusId = entity.Status.Id;
			result.StatusName = entity.Status.Name;
			result.UserId = entity.User.Id;
			result.UserName = entity.User.UserName;
			return result;
		}

		public AccountResult Convert(Data.Entity.Account param)
		{
			AccountResult result = ConvertStandart(param, new AccountResult());
			return ConvertSpecific(param, result);
		}
	}
}
