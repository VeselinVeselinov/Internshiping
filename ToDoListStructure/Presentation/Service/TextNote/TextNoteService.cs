using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.TextNote;
using ToDoListStructure.Business.Processor.TextNote;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.TextNote
{
    class TextNoteService:ITextNoteService
    {
        public TextNoteProcessor Processor { get; set; }

        public Response Create(TextNoteParam param)
        {
            throw new NotImplementedException();
        }

        public Response Create(List<TextNoteParam> param)
        {
            throw new NotImplementedException();
        }

        public Response DeleteByID(long id)
        {
            throw new NotImplementedException();
        }

        public Response Delte(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public Response FindByPK(long id)
        {
            throw new NotImplementedException();
        }

        public Response ListAll()
        {
            throw new NotImplementedException();
        }

        public Response Update(long id, TextNoteParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<TextNoteParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(TextNoteParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<TextNoteParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
