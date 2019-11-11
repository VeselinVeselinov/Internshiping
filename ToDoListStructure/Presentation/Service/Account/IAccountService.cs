using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Account;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.Account
{
    interface IAccountService
    {
		Response FindByPK(long id);

		Response FindByCode(string code);

		Response FindByName(string name);

		Response FindByAttribute(string att, string value);

		Response ListAll();

		Response Create(AccountParam param);

		Response Create(List<AccountParam> param);

		Response Update(long id, AccountParam param);

		Response Update(List<AccountParam> param);

		Response DeleteByID(long id);

		Response Delte(List<long> idList);

		void ValidateParameters(AccountParam param);

		void ValidateParameters(List<AccountParam> param);
	}
}
