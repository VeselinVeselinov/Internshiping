using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.NoteStatus
{
    interface INoteStatusProcessor
    {
<<<<<<< Updated upstream
=======
        NoteStatusResult Create(NoteStatusParam param);

        List<NoteStatusResult> Create(List<NoteStatusParam> param);

        void Update(long id, NoteStatusParam param);

        void Update(List<NoteStatusParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        NoteStatusResult Find(long id);

        List<NoteStatusResult> Find();

        NoteStatusResult FindByCode(string code);

        List<NoteStatusResult> FindByName(string name);
>>>>>>> Stashed changes
    }
}
