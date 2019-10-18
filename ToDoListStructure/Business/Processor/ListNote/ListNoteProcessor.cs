using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ListNote;
using ToDoListStructure.DataAccess.Dao.ListNote;

namespace ToDoListStructure.Business.Processor.ListNote
{
    class ListNoteProcessor:IListNoteProcessor
    {
        public ListNoteDao Dao { get; set; }

        public ListNoteParamConverter ParamConverter { get; set; }

        public ListNoteResultConverter ResultConverter { get; set; }

        public ListNoteResult Create(ListNoteParam param)
        {
            throw new NotImplementedException();
        }

        public List<ListNoteResult> Create(List<ListNoteParam> param)
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

        public ListNoteResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<ListNoteResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, ListNoteParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<ListNoteParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
