using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.ListNote
{
    class ListNoteProcessor:IListNoteProcessor
    {
<<<<<<< Updated upstream
=======
        public IListNoteDao Dao = new ListNoteDao();

        public IListNoteParamConverter ParamConverter = new ListNoteParamConverter();

        public IListNoteResultConverter ResultConverter = new ListNoteResultConverter();

        public ListNoteResult Create(ListNoteParam param)
        {
            Entities.ListNote entity = ParamConverter.Convert(param);
            entity = Dao.Save(entity);
            return ResultConverter.Convert(entity);
        }

        public List<ListNoteResult> Create(List<ListNoteParam> param)
        {
            List<Entities.ListNote> entities = new List<Entities.ListNote>();
            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }
            Dao.Save(entities);
            List<ListNoteResult> result = new List<ListNoteResult>();
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

        public ListNoteResult Find(long id)
        {
            Entities.ListNote entity = Dao.Find(id);
            return ResultConverter.Convert(entity);
        }

        public List<ListNoteResult> Find()
        {
            List<Entities.ListNote> entities = Dao.Find();
            List<ListNoteResult> results = new List<ListNoteResult>();
            entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
            return results;
        }

        public ListNoteResult FindByCode(string code)
        {
            return ResultConverter.Convert(Dao.FindByCode(code));
        }

        public List<ListNoteResult> FindByName(string name)
        {
            List<Entities.ListNote> entities = Dao.FindByName(name);
            List<ListNoteResult> result = new List<ListNoteResult>();
            entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
            return result;
        }

        public void Update(long id, ListNoteParam param)
        {
            Entities.ListNote oldEntity = Dao.Find(id);
            Entities.ListNote newEntity = ParamConverter.Convert(param, oldEntity);
            Dao.Update(newEntity);
        }

        public void Update(List<ListNoteParam> param)
        {
            List<Entities.ListNote> entity = new List<Entities.ListNote>();
            param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
            Dao.Update(entity);
        }
>>>>>>> Stashed changes
    }
}
