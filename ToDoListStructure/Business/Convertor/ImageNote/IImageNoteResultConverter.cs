using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ImageNote
{
    interface IImageNoteResultConverter
    {
        ImageNoteResult Convert(ToDoListStructure.Entities.ImageNote param);
    }
}
