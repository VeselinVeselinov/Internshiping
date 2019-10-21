using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ListNoteItem;
using ToDoListStructure.DataAccess.Dao.ListNoteItem;

namespace ToDoListStructure.Business.Processor.ListNoteItem
{
    class ListNoteItemProcessor:IListNoteItemProcessor
    {
        public IListNoteItemDao Dao { get; set; }

        public IListNoteItemParamConverter ParamConverter { get; set; }

        public IListNoteItemResultConverter ResultConverter { get; set; }

        public ListNoteItemResult Create(ListNoteItemParam param)
        {
            throw new NotImplementedException();
        }

        public List<ListNoteItemResult> Create(List<ListNoteItemParam> param)
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

        public ListNoteItemResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<ListNoteItemResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, ListNoteItemParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<ListNoteItemParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
