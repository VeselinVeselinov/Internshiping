using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListStructure.Business.Convertor.Account;
using ToDoListStructure.DataAccess.Dao.Account;

namespace ToDoListStructure.Business.Processor.Account
{
    class AccountProcessor:IAccountProcessor
    {
        public IAccountDao Dao = new AccountDao();

        public IAccountResultConverter ResultConverter = new AccountResultConverter();

        public IAccountParamConverter ParamConverter = new AccountParamConverter();

        public AccountResult Create(AccountParam param)
        {
            Entities.Account entity = ParamConverter.Convert(param,null);
            entity=Dao.Save(entity); 
            return ResultConverter.Convert(entity);
        }

        public List<AccountResult> Create(List<AccountParam> param)
        {
            List<Entities.Account> entities = new List<Entities.Account>();
            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item,null));
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
            Dao.Delete(idList);
        }

        public AccountResult Find(long id)
        {
            Entities.Account entity = Dao.Find(id);
            return ResultConverter.Convert(entity);
        }

        public List<AccountResult> Find()
        {
            List<Entities.Account> entities = Dao.Find();
            List<AccountResult> results = new List<AccountResult>();
            entities.ForEach(entity=>results.Add(ResultConverter.Convert(entity)));
            return results;
        }

		public List<AccountResult> FindByAttribute(string att, string value)
		{
			List<Entities.Account> entities = Dao.FindByAttribute(att,value);
			List<AccountResult> result = new List<AccountResult>();
			entities.ForEach(entity=>result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public AccountResult FindByCode(int code)
        {
            return ResultConverter.Convert(Dao.FindByCode(code));
        }

        public List<AccountResult> FindByName(string name)
        {
            List<Entities.Account> entities = Dao.FindByName(name);
            List<AccountResult> result = new List<AccountResult>();
            entities.ForEach(entity=>result.Add(ResultConverter.Convert(entity)));
            return result;
        }

        public void Update(long id, AccountParam param)
        {
            //validaciq ako old entity e null?
            Entities.Account oldEntity = Dao.Find(id);
            Entities.Account newEntity = ParamConverter.Convert(param, oldEntity);
            Dao.Update(newEntity);
        }

        public void Update(List<AccountParam> param)
        {
            List<Entities.Account> entity = new List<Entities.Account>();
            param.ForEach(item => entity.Add(ParamConverter.Convert(item,null)));
            Dao.Update(entity);
        }
    }
}
