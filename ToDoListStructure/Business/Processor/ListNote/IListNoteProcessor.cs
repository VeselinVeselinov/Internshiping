using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.ListNote
{
    interface IListNoteProcessor
    {
<<<<<<< Updated upstream
=======
        ListNoteResult Create(ListNoteParam param);

        List<ListNoteResult> Create(List<ListNoteParam> param);

        void Update(long id, ListNoteParam param);

        void Update(List<ListNoteParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        ListNoteResult Find(long id);

        List<ListNoteResult> Find();

        ListNoteResult FindByCode(string code);

        List<ListNoteResult> FindByName(string name);
>>>>>>> Stashed changes
    }
}
