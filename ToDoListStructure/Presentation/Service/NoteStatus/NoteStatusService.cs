using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.NoteStatus;
using ToDoListStructure.Business.Processor.NoteStatus;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.NoteStatus
{
    class NoteStatusService:INoteStatusService
    {
        public INoteStatusProcessor Processor { get; set; }

        public Response Create(NoteStatusParam param)
        {
            throw new NotImplementedException();
        }

        public Response Create(List<NoteStatusParam> param)
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

        public Response Update(long id, NoteStatusParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<NoteStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(NoteStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<NoteStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
