using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.ImageNote
{
    interface IImageNoteProcessor
    {
<<<<<<< Updated upstream
=======
        ImageNoteResult Create(ImageNoteParam param);

        List<ImageNoteResult> Create(List<ImageNoteParam> param);

        void Update(long id, ImageNoteParam param);

        void Update(List<ImageNoteParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        ImageNoteResult Find(long id);

        List<ImageNoteResult> Find();

        ImageNoteResult FindByCode(string code);

        List<ImageNoteResult> FindByName(string name);
>>>>>>> Stashed changes
    }
}
