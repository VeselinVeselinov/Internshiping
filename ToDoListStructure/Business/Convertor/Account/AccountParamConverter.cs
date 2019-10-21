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
        public IAccountDao Dao { get; set; }

        public Entities.Account Convert(AccountParam param)
        {
            Entities.Account entity = new Entities.Account()
            {
                ID = param.Id,
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
            return entity;
        }
    }
}
