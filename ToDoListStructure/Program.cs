using System;
<<<<<<< Updated upstream
using ToDoListStructure.Entities.Notes;
using ToDoListStructure.Entities.Actions;
using ToDoListStructure.Entities.Consumers;
=======
using ToDoListStructure.Business.Convertor.Account;
using ToDoListStructure.Entities;
using ToDoListStructure.Presentation.Service.Account;
using Newtonsoft.Json;
using ToDoListStructure.Business.Processor.Account;
using ToDoListStructure.DataAccess.Dao.Account;
using ToDoListStructure.Data.Common;
using System.Collections.Generic;
using ToDoListStructure.Presentation.Service.AccountStatus;
using ToDoListStructure.Business.Convertor.AccountStatus;
using ToDoListStructure.Presentation.Service.User;
using ToDoListStructure.Business.Convertor.User;
>>>>>>> Stashed changes

namespace ToDoListStructure
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            Account Vesko = new Account();
            Account Vasko = new Account();
            TextNote Note1 = new TextNote();
            Note1.Content = "Today i will order pizza";
            Console.WriteLine(Note1.Content);

            Share spodelqnka = new Share();
            

            Console.WriteLine();
            
=======
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
			AccountStatusParam status = new AccountStatusParam()
			{
				Id = 4,
				Code = "ToshkoAccStatus",
				Name = "Active",
				Description = "Acc status for Toshko's account"
			};

			UserParam userParam = new UserParam()
			{
				Id=4,
				UserName="ToshkoTheStudent",
				Password="123456789toshko",
				Status=null
			};

			AccountStatusService accountStatusService = new AccountStatusService();
			accountStatusService.Create(status);

			UserService userService = new UserService();
			userService.Create(userParam);


            AccountParam account = new AccountParam()
            {
                Id = 4,
                Code = "ToshkoAcc",
                Name ="Toshko",
                Description ="Student account for Toshko.",
                FirstName ="Teodor",
                LastName ="The student",
				StatusId=1,
				UserId=1,
				Address="123",
				Email="eqeqweqw",
				Phone="32132432"
            };

			AccountService service = new AccountService();

			//         Console.WriteLine(service.Create(account).Text);
			//         Console.WriteLine(service.Create(account1).Text);
			//         Console.WriteLine(service.ListAll().Text);
			//         Console.WriteLine(service.FindByPK(1).Text);
			//         Console.WriteLine(service.DeleteByID(1).Text);
			//         Console.WriteLine(service.ListAll().Text);
			//         Console.WriteLine(service.FindByPK(1).Text);
			//         Console.WriteLine(service.Update(2, account).Text);
			//         Console.WriteLine(service.ListAll().Text);
			//         Console.WriteLine(service.FindByCode(15).Text);
			//         Console.WriteLine(service.FindByName("Toshko").Text);
			//         Console.WriteLine(service.DeleteByID(5).Text);
			//         Console.WriteLine(service.ListAll().Text);

			//         AccountStatusService accountStatusService = new AccountStatusService();
			//         Console.WriteLine(accountStatusService.ListAll().Text);
			//         Console.WriteLine(accountStatusService.Create(new AccountStatusParam() {Id=5,Name="qj mi uq" }).Text);
			//         Console.WriteLine(accountStatusService.Create(new AccountStatusParam() { Id = 5, Name = "qj mi uq" }).Text);

			//         Console.WriteLine(accountStatusService.ListAll().Text);
			//         Console.WriteLine(accountStatusService.DeleteByID(5).Text);
			//         Console.WriteLine(accountStatusService.ListAll().Text);
			//Console.WriteLine("------------------------");
			//Console.WriteLine(service.ListAll().Text);
			//Console.WriteLine(service.FindByAttribute("ID", "3").Text);

			Console.WriteLine(service.Create(account).Text);
			Console.WriteLine(service.ListAll().Text);
			Console.WriteLine(service.ListAll().Text);
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
>>>>>>> Stashed changes
        }
    }
}
