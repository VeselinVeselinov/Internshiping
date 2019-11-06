using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.AccountStatus
{
    interface IAccountStatusProcessor
    {
<<<<<<< Updated upstream
=======
        AccountStatusResult Create(AccountStatusParam param);

        List<AccountStatusResult> Create(List<AccountStatusParam> param);

        void Update(long id, AccountStatusParam param);

        void Update(List<AccountStatusParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        AccountStatusResult Find(long id);

        List<AccountStatusResult> Find();

        AccountStatusResult FindByCode(string code);

        List<AccountStatusResult> FindByName(string name);
>>>>>>> Stashed changes
    }
}
