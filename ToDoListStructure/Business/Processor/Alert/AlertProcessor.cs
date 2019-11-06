using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.Alert
{
    class AlertProcessor:IAlertProcessor
    {
<<<<<<< Updated upstream
=======
        public IAlertDao Dao = new AlertDao();

        public IAlertResultConverter ResultConverter = new AlertResultConverter();

        public IAlertParamConverter ParamConverter = new AlertParamConverter();

        public AlertResult Create(AlertParam param)
        {
            Entities.Alert entity = ParamConverter.Convert(param);
            entity = Dao.Save(entity);
            return ResultConverter.Convert(entity);
        }

        public List<AlertResult> Create(List<AlertParam> param)
        {
            List<Entities.Alert> entities = new List<Entities.Alert>();
            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }
            Dao.Save(entities);
            List<AlertResult> result = new List<AlertResult>();
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

        public AlertResult Find(long id)
        {
            Entities.Alert entity = Dao.Find(id);
            return ResultConverter.Convert(entity);
        }

        public List<AlertResult> Find()
        {
            List<Entities.Alert> entities = Dao.Find();
            List<AlertResult> results = new List<AlertResult>();
            entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
            return results;
        }

        public AlertResult FindByCode(string code)
        {
            return ResultConverter.Convert(Dao.FindByCode(code));
        }

        public List<AlertResult> FindByName(string name)
        {
            List<Entities.Alert> entities = Dao.FindByName(name);
            List<AlertResult> result = new List<AlertResult>();
            entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
            return result;
        }

        public void Update(long id, AlertParam param)
        {
            Entities.Alert oldEntity = Dao.Find(id);
            Entities.Alert newEntity = ParamConverter.Convert(param, oldEntity);
            Dao.Update(newEntity);
        }

        public void Update(List<AlertParam> param)
        {
            List<Entities.Alert> entity = new List<Entities.Alert>();
            param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
            Dao.Update(entity);
        }
>>>>>>> Stashed changes
    }
}
