using System;
using ToDoListStructure.Business.Convertor.Account;
using ToDoListStructure.Entities;
using ToDoListStructure.Presentation.Service.Account;
using Newtonsoft.Json;
using ToDoListStructure.Business.Processor.Account;
using ToDoListStructure.DataAccess.Dao.Account;

namespace ToDoListStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account() { FirstName="Toni", LastName="Jicata", Address="Stolipinovo", Email="Jicata@abv.bg", Phone="123"};
            string converted = JsonConvert.SerializeObject(account);
            
            
            AccountParamConverter converterParam = new AccountParamConverter();
            AccountResultConverter converterResult = new AccountResultConverter();
            AccountDao dao = new AccountDao();
            AccountProccesor proccesor = new AccountProccesor() {Dao=dao,ParamConverter=converterParam,ResultConverter=converterResult };
            AccountService service = new AccountService() { Processor = proccesor };

            AccountParam param = new AccountParam() { Input = converted };
            
            Console.WriteLine(service.Create(param).Text);
            
        }
    }
}
