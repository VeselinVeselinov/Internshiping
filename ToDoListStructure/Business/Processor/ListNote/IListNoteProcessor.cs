using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ListNote;

namespace ToDoListStructure.Business.Processor.ListNote
{
    interface IListNoteProcessor
    {
        ListNoteResult Create(ListNoteParam param);

        List<ListNoteResult> Create(List<ListNoteParam> param);

        void Update(long id, ListNoteParam param);

        void Update(List<ListNoteParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        ListNoteResult Find(long id);

        List<ListNoteResult> Find();
    }
}
