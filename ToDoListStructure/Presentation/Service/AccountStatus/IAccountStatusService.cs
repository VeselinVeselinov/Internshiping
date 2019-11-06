using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Presentation.Service.AccountStatus
{
    interface IAccountStatusService
    {
<<<<<<< Updated upstream
=======
        Response FindByPK(long id);

        Response FindByCode(string code);

        Response FindByName(string name);

        Response ListAll();

        Response Create(AccountStatusParam param);

        Response Create(List<AccountStatusParam> param);

        Response Update(long id, AccountStatusParam param);

        Response Update(List<AccountStatusParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(AccountStatusParam param);

        void ValidateParameters(List<AccountStatusParam> param);
>>>>>>> Stashed changes
    }
}
