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
            Entities.Account entity = ParamConverter.Convert(param);
            entity=Dao.Save(entity); 
            return ResultConverter.Convert(entity);
        }

        public List<AccountResult> Create(List<AccountParam> param)
        {
            List<Entities.Account> entities = new List<Entities.Account>();
            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }
            Dao.Save(entities);
            List<AccountResult> result = new List<AccountResult>();
            foreach(var item in entities)
            {
                result.Add(ResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            // chrez param converter poluchavame list ot entities.account i gi podavame na delete(list ot entities)

            Dao.Delete(idList);
        }

        public AccountResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<AccountResult> Find()
        {
            List<Entities.Account> accounts = Dao.Find();
            List<AccountResult> results = new List<AccountResult>();
            foreach (var item in accounts)
            {
                results.Add(ResultConverter.Convert(item));
            }
            return results;

        }

        public void Update(long id, AccountParam param)
        {
            //Dao.Update();
            throw new NotImplementedException();
        }

        public void Update(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
