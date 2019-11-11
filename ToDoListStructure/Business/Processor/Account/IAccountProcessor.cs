using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Account;

namespace ToDoListStructure.Business.Processor.Account
{
    interface IAccountProcessor
    {
        AccountResult Create(AccountParam param);

        List<AccountResult> Create(List<AccountParam> param);

        void Update(long id, AccountParam param);

        void Update(List<AccountParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        AccountResult Find(long id);

        AccountResult FindByCode(string code);

        List<AccountResult> FindByName(string name);

        List<AccountResult> Find();

		List<AccountResult> FindByAttribute(string att, string value);
	}
}
