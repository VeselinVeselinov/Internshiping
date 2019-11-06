using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.ListNoteItem
{
    class ListNoteItemProcessor:IListNoteItemProcessor
    {
<<<<<<< Updated upstream
=======
        public IListNoteItemDao Dao = new ListNoteItemDao();

        public IListNoteItemParamConverter ParamConverter = new ListNoteItemParamConverter();

        public IListNoteItemResultConverter ResultConverter = new ListNoteItemResultConverter();

        public ListNoteItemResult Create(ListNoteItemParam param)
        {
            Entities.ListNoteItem entity = ParamConverter.Convert(param);
            entity = Dao.Save(entity);
            return ResultConverter.Convert(entity);
        }

        public List<ListNoteItemResult> Create(List<ListNoteItemParam> param)
        {
            List<Entities.ListNoteItem> entities = new List<Entities.ListNoteItem>();
            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }
            Dao.Save(entities);
            List<ListNoteItemResult> result = new List<ListNoteItemResult>();
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

        public ListNoteItemResult Find(long id)
        {
            Entities.ListNoteItem entity = Dao.Find(id);
            return ResultConverter.Convert(entity);
        }

        public List<ListNoteItemResult> Find()
        {
            List<Entities.ListNoteItem> entities = Dao.Find();
            List<ListNoteItemResult> results = new List<ListNoteItemResult>();
            entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
            return results;
        }

        public ListNoteItemResult FindByCode(string code)
        {
            return ResultConverter.Convert(Dao.FindByCode(code));
        }

        public List<ListNoteItemResult> FindByName(string name)
        {
            List<Entities.ListNoteItem> entities = Dao.FindByName(name);
            List<ListNoteItemResult> result = new List<ListNoteItemResult>();
            entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
            return result;
        }

        public void Update(long id, ListNoteItemParam param)
        {
            Entities.ListNoteItem oldEntity = Dao.Find(id);
            Entities.ListNoteItem newEntity = ParamConverter.Convert(param, oldEntity);
            Dao.Update(newEntity);
        }

        public void Update(List<ListNoteItemParam> param)
        {
            List<Entities.ListNoteItem> entity = new List<Entities.ListNoteItem>();
            param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
            Dao.Update(entity);
        }
>>>>>>> Stashed changes
    }
}
