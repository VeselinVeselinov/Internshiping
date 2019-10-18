using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ImageNote;

namespace ToDoListStructure.Business.Processor.ImageNote
{
    interface IImageNoteProcessor
    {
        ImageNoteResult Create(ImageNoteParam param);

        List<ImageNoteResult> Create(List<ImageNoteParam> param);

        void Update(long id, ImageNoteParam param);

        void Update(List<ImageNoteParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        ImageNoteResult Find(long id);

        List<ImageNoteResult> Find();
    }
}
