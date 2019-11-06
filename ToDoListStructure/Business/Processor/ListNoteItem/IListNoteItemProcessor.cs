using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.ListNoteItem
{
    interface IListNoteItemProcessor
    {
<<<<<<< Updated upstream
=======
        ListNoteItemResult Create(ListNoteItemParam param);

        List<ListNoteItemResult> Create(List<ListNoteItemParam> param);

        void Update(long id, ListNoteItemParam param);

        void Update(List<ListNoteItemParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        ListNoteItemResult Find(long id);

        List<ListNoteItemResult> Find();

        ListNoteItemResult FindByCode(string code);

        List<ListNoteItemResult> FindByName(string name);
>>>>>>> Stashed changes
    }
}
