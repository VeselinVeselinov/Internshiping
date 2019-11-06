using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Account
{
    interface IAccountResultConverter: IBaseResultConverter<Entities.Account, AccountResult>
    {
<<<<<<< Updated upstream
=======
        AccountResult Convert(Entities.Account param);
>>>>>>> Stashed changes
    }
}
