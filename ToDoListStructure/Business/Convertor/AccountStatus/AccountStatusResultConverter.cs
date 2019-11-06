using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.AccountStatus
{
    class AccountStatusResultConverter:IAccountStatusResultConverter
    {
<<<<<<< Updated upstream
=======
        public AccountStatusResult Convert(Entities.AccountStatus param)
        {
            AccountStatusResult result = new AccountStatusResult()
            {
                Id=param.Id,
                Code=param.Code,
                Name=param.Name,
                Description=param.Description
            };
            return result;
        }
>>>>>>> Stashed changes
    }
}
