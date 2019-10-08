using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ListNote;
using ToDoListStructure.DataAccess.Dao.ListNote;

namespace ToDoListStructure.Business.Processor.ListNote
{
    class ListNoteProcessor:IListNoteProcessor
    {
        public ListNoteDao Dao { get; set; }

        public ListNoteParamConverter ParamConverter { get; set; }

        public ListNoteResultConverter ResultConverter { get; set; }
    }
}
