using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.AlertStatus
{
    class AlertStatusProcessor:IAlertStatusProcessor
    {
<<<<<<< Updated upstream
=======
        public IAlertStatusDao Dao = new AlertStatusDao();

        public IAlertStatusResultConverter ResultConverter = new AlertStatusResultConverter();

        public IAlertStatusParamConverter ParamConverter = new AlertStatusParamConverter();

        public AlertStatusResult Create(AlertStatusParam param)
        {
            Entities.AlertStatus entity = ParamConverter.Convert(param);
            entity = Dao.Save(entity);
            return ResultConverter.Convert(entity);
        }

        public List<AlertStatusResult> Create(List<AlertStatusParam> param)
        {
            List<Entities.AlertStatus> entities = new List<Entities.AlertStatus>();
            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }
            Dao.Save(entities);
            List<AlertStatusResult> result = new List<AlertStatusResult>();
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

        public AlertStatusResult Find(long id)
        {
            Entities.AlertStatus entity = Dao.Find(id);
            return ResultConverter.Convert(entity);
        }

        public List<AlertStatusResult> Find()
        {
            List<Entities.AlertStatus> entities = Dao.Find();
            List<AlertStatusResult> results = new List<AlertStatusResult>();
            entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
            return results;
        }

        public AlertStatusResult FindByCode(string code)
        {
            return ResultConverter.Convert(Dao.FindByCode(code));
        }

        public List<AlertStatusResult> FindByName(string name)
        {
            List<Entities.AlertStatus> entities = Dao.FindByName(name);
            List<AlertStatusResult> result = new List<AlertStatusResult>();
            entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
            return result;
        }

        public void Update(long id, AlertStatusParam param)
        {
            Entities.AlertStatus oldEntity = Dao.Find(id);
            Entities.AlertStatus newEntity = ParamConverter.Convert(param, oldEntity);
            Dao.Update(newEntity);
        }

        public void Update(List<AlertStatusParam> param)
        {
            List<Entities.AlertStatus> entity = new List<Entities.AlertStatus>();
            param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
            Dao.Update(entity);
        }
>>>>>>> Stashed changes
    }
}
