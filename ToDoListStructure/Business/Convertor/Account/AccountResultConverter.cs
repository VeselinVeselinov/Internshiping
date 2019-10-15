using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.Account
{
    class AccountResultConverter : IAccountResultConverter
    {
        public AccountResult Convert(Entities.Account param)
        {
            AccountResult result = new AccountResult() { Converted = JsonConvert.SerializeObject(param) };
            return result;
        }
    }
}
