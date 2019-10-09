using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.NoteStatus;
using ToDoListStructure.DataAccess.Dao.NoteStatus;

namespace ToDoListStructure.Business.Processor.NoteStatus
{
    class NoteStatusProcessor:INoteStatusProcessor
    {
        public NoteStatusDao Dao { get; set; }

        public NoteStatusParamConverter ParamConverter { get; set; }

        public NoteStatusResultConverter ResultConverter { get; set; }
    }
}
