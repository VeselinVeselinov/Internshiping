using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.NoteStatus
{
    class NoteStatusProcessor:INoteStatusProcessor
    {
<<<<<<< Updated upstream
=======
        public INoteStausDao Dao = new NoteStatusDao();

        public INoteStatusParamConverter ParamConverter = new NoteStatusParamConverter();

        public INoteStatusResultConverter ResultConverter = new NoteStatusResultConverter();

        public NoteStatusResult Create(NoteStatusParam param)
        {
            Entities.NoteStatus entity = ParamConverter.Convert(param);
            entity = Dao.Save(entity);
            return ResultConverter.Convert(entity);
        }

        public List<NoteStatusResult> Create(List<NoteStatusParam> param)
        {
            List<Entities.NoteStatus> entities = new List<Entities.NoteStatus>();
            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }
            Dao.Save(entities);
            List<NoteStatusResult> result = new List<NoteStatusResult>();
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

        public NoteStatusResult Find(long id)
        {
            Entities.NoteStatus entity = Dao.Find(id);
            return ResultConverter.Convert(entity);
        }

        public List<NoteStatusResult> Find()
        {
            List<Entities.NoteStatus> entities = Dao.Find();
            List<NoteStatusResult> results = new List<NoteStatusResult>();
            entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
            return results;
        }

        public NoteStatusResult FindByCode(string code)
        {
            return ResultConverter.Convert(Dao.FindByCode(code));
        }

        public List<NoteStatusResult> FindByName(string name)
        {
            List<Entities.NoteStatus> entities = Dao.FindByName(name);
            List<NoteStatusResult> result = new List<NoteStatusResult>();
            entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
            return result;
        }

        public void Update(long id, NoteStatusParam param)
        {
            Entities.NoteStatus oldEntity = Dao.Find(id);
            Entities.NoteStatus newEntity = ParamConverter.Convert(param, oldEntity);
            Dao.Update(newEntity);
        }

        public void Update(List<NoteStatusParam> param)
        {
            List<Entities.NoteStatus> entity = new List<Entities.NoteStatus>();
            param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
            Dao.Update(entity);
        }
>>>>>>> Stashed changes
    }
}
