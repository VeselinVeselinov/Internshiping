using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.NoteStatus;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.NoteStatus
{
    class NoteStatusParamConverter:INoteStatusParamConverter
    {
        public NoteStatusDao Dao { get; set; }

        public Entities.NoteStatus Convert(NoteStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
