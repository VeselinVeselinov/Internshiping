using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.ListNote;

namespace ToDoListStructure.Presentation.Service.ListNote
{
    class ListNoteService:IListNoteService
    {
        public ListNoteProcessor Processor { get; set; }
    }
}
