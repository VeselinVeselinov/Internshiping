using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.NoteStatus;

namespace ToDoListStructure.Presentation.Service.NoteStatus
{
    class NoteStatusService:INoteStatusService
    {
        public NoteStatusProcessor Processor { get; set; }
    }
}
