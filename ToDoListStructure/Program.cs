using System;
using ToDoListStructure.Business.Convertor.Account;
using ToDoListStructure.Data.Entity;
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

            AccountParam substitute = new AccountParam()
            {
                Id = 4,
                Code = "random",
                Name ="ThisIsATest",
                Description ="Testing for missing properties.",
                FirstName ="Tester",
                LastName ="For param conv",
				UserId=13,
				StatusId=12
            };

            AccountParam main = new AccountParam()
            {
                Id = 4,
                Code = "15",
                Name = "Koko",
                Description = "Student account for me.",
                FirstName = "Koko",
                LastName = "Kokov",
				Address="Anonymous",
				Email="random@abv.bg",
				Phone="+359874225648",
				UserId=3,
				StatusId=3
            };

			AccountParam listItem1 = new AccountParam()
			{
				Id = 44,
				Code = "15",
				Name = "Pecata",
				Description = "Student account for me.",
				FirstName = "Petur",
				LastName = "PEcov",
				Address = "Anonymous",
				Email = "random@abv.bg",
				Phone = "+359874225648",
				UserId = 1,
				StatusId = 1
			};
			AccountParam listItem2 = new AccountParam()
			{
				Id = 43,
				Code = "15",
				Name = "Jivko",
				Description = "Student account for me.",
				FirstName = "Jivko",
				LastName = "Jivkov",
				Address = "Anonymous",
				Email = "random@abv.bg",
				Phone = "+359874225648",
				UserId = 1,
				StatusId = 1
			};


			AccountService service = new AccountService();

			Console.WriteLine(service.Create(main).Text);
			Console.WriteLine(service.FindByCode("f").Text);
			Console.WriteLine(service.ListAll().Text);
			Console.WriteLine(service.Update(new List<AccountParam> { listItem1, listItem2, substitute }).Text);
			Console.WriteLine(service.Create(new List<AccountParam> { main,substitute}).Text);
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
                        param.Code =(Console.ReadLine());
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
