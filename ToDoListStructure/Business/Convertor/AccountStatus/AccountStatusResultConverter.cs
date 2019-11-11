using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.AccountStatus
{
    class AccountStatusResultConverter : BaseResultConverter<Data.Entity.AccountStatus,AccountStatusResult>,IAccountStatusResultConverter
    {
		public override AccountStatusResult ConvertSpecific(Data.Entity.AccountStatus entity, AccountStatusResult result)
		{
			throw new NotImplementedException();
		}

		public AccountStatusResult Convert(Data.Entity.AccountStatus param)
        {
			AccountStatusResult result = ConvertStandart(param, new AccountStatusResult());

            return result;
        }
	}
}
