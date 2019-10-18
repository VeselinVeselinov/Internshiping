using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ImageNote
{
    interface IImageNoteParamConverter
    {
        ToDoListStructure.Entities.ImageNote Convert(ImageNoteParam param);
    }
}
