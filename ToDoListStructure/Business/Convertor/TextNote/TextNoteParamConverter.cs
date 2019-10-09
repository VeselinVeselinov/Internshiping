using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.TextNote;

namespace ToDoListStructure.Business.Convertor.TextNote
{
    class TextNoteParamConverter:ITextNoteParamConverter
    {
        public TextNoteDao Dao { get; set; }
    }
}
