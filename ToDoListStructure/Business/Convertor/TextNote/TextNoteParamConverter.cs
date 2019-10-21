using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.TextNote;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.TextNote
{
    class TextNoteParamConverter:ITextNoteParamConverter
    {
        public ITextNoteDao Dao { get; set; }

        public Entities.TextNote Convert(TextNoteParam param)
        {
            throw new NotImplementedException();
        }
    }
}
