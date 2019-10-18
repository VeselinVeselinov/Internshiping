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
            AccountResult result = new AccountResult()
            {
                Id = param.ID,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                FirstName = param.FirstName,
                LastName = param.LastName,
                Address = param.Address,
                Phone = param.Phone,
                Email = param.Email,
                User = param.User,
                Status = param.Status
            };
            return result;
        }
    }
}
