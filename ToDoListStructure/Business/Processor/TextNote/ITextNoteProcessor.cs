using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.TextNote
{
    interface ITextNoteProcessor
    {
<<<<<<< Updated upstream
    }
=======
        TextNoteResult Create(TextNoteParam param);

        List<TextNoteResult> Create(List<TextNoteParam> param);

        void Update(long id, TextNoteParam param);

        void Update(List<TextNoteParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        TextNoteResult Find(long id);

        List<TextNoteResult> Find();

		TextNoteResult FindByCode(string code);

		List<TextNoteResult> FindByName(string name);
	}
>>>>>>> Stashed changes
}
