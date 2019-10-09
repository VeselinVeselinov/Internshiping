using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.TextNote;
using ToDoListStructure.DataAccess.Dao.TextNote;

namespace ToDoListStructure.Business.Processor.TextNote
{
    class TextNoteProcessor:ITextNoteProcessor
    {
        public TextNoteDao Dao { get; set; }

        public TextNoteParamConverter ParamConverter { get; set; }

        public TextNoteResultConverter ResultConverter { get; set; }
    }
}
