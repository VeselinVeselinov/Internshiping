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
            string converted= JsonConvert.SerializeObject(param);
            AccountResult result = new AccountResult() {result=converted};
            return result;
        }
    }
}
