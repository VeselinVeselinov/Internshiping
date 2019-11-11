using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.TextNote;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.TextNote
{
    class TextNoteParamConverter:ITextNoteParamConverter
    {
        public ITextNoteDao Dao { get; set; }

        public Data.Entity.TextNote Convert(TextNoteParam param)
        {
            throw new NotImplementedException();
        }
    }
}
