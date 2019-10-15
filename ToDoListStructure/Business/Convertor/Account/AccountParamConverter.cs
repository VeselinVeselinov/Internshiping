using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.Account;
using ToDoListStructure.Entities;
using Newtonsoft.Json;

namespace ToDoListStructure.Business.Convertor.Account
{
    class AccountParamConverter:IAccountParamConverter
    {
        public AccountDao Dao { get; set; }

        public Entities.Account Convert(AccountParam param)
        {
            return JsonConvert.DeserializeObject<Entities.Account>(param.jsonInput);
        }
    }
}
