using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.Account
{
    interface IAccountProcessor
    {
<<<<<<< Updated upstream
=======
        AccountResult Create(AccountParam param);

        List<AccountResult> Create(List<AccountParam> param);

        void Update(long id, AccountParam param);

        void Update(List<AccountParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        AccountResult Find(long id);

        AccountResult FindByCode(int code);

        List<AccountResult> FindByName(string name);

        List<AccountResult> Find();

		List<AccountResult> FindByAttribute(string att, string value);
>>>>>>> Stashed changes
    }
}
