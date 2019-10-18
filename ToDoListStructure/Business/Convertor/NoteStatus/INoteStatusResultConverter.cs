using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.NoteStatus
{
    interface INoteStatusResultConverter
    {
        NoteStatusResult Convert(ToDoListStructure.Entities.NoteStatus param);
    }
}
