using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.TextNote;
using ToDoListStructure.DataAccess.Dao.TextNote;

namespace ToDoListStructure.Business.Processor.TextNote
{
    class TextNoteProcessor:ITextNoteProcessor
    {
        public ITextNoteDao Dao { get; set; }

        public ITextNoteParamConverter ParamConverter { get; set; }

        public ITextNoteResultConverter ResultConverter { get; set; }

        public TextNoteResult Create(TextNoteParam param)
        {
            throw new NotImplementedException();
        }

        public List<TextNoteResult> Create(List<TextNoteParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public TextNoteResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<TextNoteResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, TextNoteParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<TextNoteParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
