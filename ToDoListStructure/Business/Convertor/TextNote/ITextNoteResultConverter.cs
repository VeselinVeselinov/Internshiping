using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.TextNote
{
    interface ITextNoteResultConverter
    {
        TextNoteResult Convert(ToDoListStructure.Data.Entity.TextNote param);
    }
}
