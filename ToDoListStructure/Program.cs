using System;
using ToDoListStructure.Business.Convertor.Account;
using ToDoListStructure.Entities;
using ToDoListStructure.Presentation.Service.Account;
using Newtonsoft.Json;

namespace ToDoListStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account() { FirstName="nqma"};
            string input = JsonConvert.SerializeObject(account);
            AccountService accountService = new AccountService();
            AccountParam param = new AccountParam() { jsonInput = input };
            
            Console.WriteLine(accountService.Create(param).Text);
            
        }
    }
}
