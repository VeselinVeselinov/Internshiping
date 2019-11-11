using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.AccountStatus;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.AccountStatus
{
    interface IAccountStatusService
    {
		Response FindByPK(long id);

		Response FindByCode(string code);

		Response FindByName(string name);

		Response FindByAttribute(string att, string value);

		Response ListAll();

		Response Create(AccountStatusParam param);

		Response Create(List<AccountStatusParam> param);

		Response Update(long id, AccountStatusParam param);

		Response Update(List<AccountStatusParam> param);

		Response DeleteByID(long id);

		Response Delte(List<long> idList);

		void ValidateParameters(AccountStatusParam param);

		void ValidateParameters(List<AccountStatusParam> param);
	}
}
