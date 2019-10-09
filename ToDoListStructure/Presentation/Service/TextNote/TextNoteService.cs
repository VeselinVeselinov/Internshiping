using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.TextNote;

namespace ToDoListStructure.Presentation.Service.TextNote
{
    class TextNoteService:ITextNoteService
    {
        public TextNoteProcessor Processor { get; set; }
    }
}
