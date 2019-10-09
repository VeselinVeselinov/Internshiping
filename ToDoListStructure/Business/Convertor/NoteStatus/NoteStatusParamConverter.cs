using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.NoteStatus;

namespace ToDoListStructure.Business.Convertor.NoteStatus
{
    class NoteStatusParamConverter:INoteStatusParamConverter
    {
        public NoteStatusDao Dao { get; set; }
    }
}
