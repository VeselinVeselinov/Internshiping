using System;
using ToDoListStructure.Business.Convertor.Account;
using ToDoListStructure.Entities;
using ToDoListStructure.Presentation.Service.Account;
using Newtonsoft.Json;
using ToDoListStructure.Business.Processor.Account;
using ToDoListStructure.DataAccess.Dao.Account;
using ToDoListStructure.Data.Common;
using System.Collections.Generic;

namespace ToDoListStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] questions = new string[] 
            //{
            //    "Please enter your accoun's ID:",
            //    "Enter your account's code",
            //    "Enter your account's name",
            //    "Enter your account's description",
            //    "Enter your first name",
            //    "Enter your last name",
            //    "Enter your address",
            //    "Enter your phone",
            //    "Enter your email"
            //};

            AccountParam account = new AccountParam() { Id = 1, Code = 15, Name="Toshko", Description="student account for me",FirstName="Teodor",LastName="Kukata"};

            AccountDao dao = new AccountDao();
            AccountParamConverter paramConverter = new AccountParamConverter() { Dao = dao };
            AccountResultConverter resultConverter = new AccountResultConverter() { };
            AccountProccesor proccesor = new AccountProccesor()
            {
                Dao = dao,
                ParamConverter = paramConverter,
                ResultConverter = resultConverter
            };

            AccountService service = new AccountService() {Processor=proccesor, Response= new Response()};
            service.Create(account);
            Console.WriteLine(service.Response.Text);

            service.FindByPK(1);
            Console.WriteLine(service.Response.Text);

            service.DeleteByID(1);
            Console.WriteLine(service.Response.Text);

            service.ListAll();
            Console.WriteLine(service.Response.Text);


            service.FindByPK(1);
            Console.WriteLine(service.Response.Text);

        }

        static void GetParamInput(AccountParam param, string [] questions)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(questions[i]);
                switch (i)
                {
                    case 0:
                        param.Id = int.Parse(Console.ReadLine());
                        break;
                    case 1:
                        param.Code = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        param.Name = Console.ReadLine();
                        break;
                    case 3:
                        param.Description = Console.ReadLine();
                        break;
                    case 4:
                        param.FirstName = Console.ReadLine();
                        break;
                    case 5:
                        param.LastName = Console.ReadLine();
                        break;
                    case 6:
                        param.Address = Console.ReadLine();
                        break;
                    case 7:
                        param.Phone = Console.ReadLine();
                        break;
                    case 8:
                        param.Email = Console.ReadLine();
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------");
        }
    }
}
