using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.NoteStatus;
using ToDoListStructure.DataAccess.Dao.NoteStatus;

namespace ToDoListStructure.Business.Processor.NoteStatus
{
    class NoteStatusProcessor:INoteStatusProcessor
    {
        public INoteStatusDao Dao { get; set; }

        public INoteStatusParamConverter ParamConverter { get; set; }

        public INoteStatusResultConverter ResultConverter { get; set; }

        public NoteStatusResult Create(NoteStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<NoteStatusResult> Create(List<NoteStatusParam> param)
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

        public NoteStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<NoteStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, NoteStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<NoteStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
