using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Account;
using ToDoListStructure.DataAccess.Dao.Account;

namespace ToDoListStructure.Business.Processor.Account
{
    class AccountProccesor:IAccountProcessor
    {
        public AccountDao Dao { get; set; }

        public AccountResultConverter ResultConverter { get; set; }

        public AccountParamConverter ParamConverter { get; set; }

        public AccountResult Create(AccountParam param)
        {
            ToDoListStructure.Entities.Account entity = ParamConverter.Convert(param);
            Console.WriteLine(entity.FirstName);
            Dao.Save(entity);
            return ResultConverter.Convert(entity);
        }

        public List<AccountResult> Create(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public AccountResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<AccountResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, AccountParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
