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
        public IAccountDao Dao { get; set; }

        public IAccountResultConverter ResultConverter { get; set; }

        public IAccountParamConverter ParamConverter { get; set; }

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
            entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Entities.Account> entity = new List<Entities.Account>();
            foreach (var id in idList)
            {
                entity.Add(Dao.Find(id));
            }
            Dao.Delete(entity);

        }

        public AccountResult Find(long id)
        {
            Entities.Account entity = Dao.Find(id);
            AccountResult result = ResultConverter.Convert(entity);
            return result;
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
            //Entities.Account oldEntity = Dao.Find(id);
            //Entities.Account newEntity = ParamConverter.Convert(param);
            //Dao.Delete(oldEntity);
            //Dao.Update(newEntity);
        }

        public void Update(List<AccountParam> param)
        {
            //List<Entities.Account> entity = new List<Entities.Account>();
            //foreach (var item in param)
            //{
            //    Dao.Delete(item.Id);
            //    entity.Add(ParamConverter.Convert(item));
            //}
            //Dao.Update(entity);
        }
    }
}
