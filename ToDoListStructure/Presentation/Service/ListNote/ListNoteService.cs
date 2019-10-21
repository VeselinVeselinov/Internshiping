using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ListNote;
using ToDoListStructure.Business.Processor.ListNote;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.ListNote
{
    class ListNoteService:IListNoteService
    {
        public IListNoteProcessor Processor { get; set; }

        public Response Create(ListNoteParam param)
        {
            throw new NotImplementedException();
        }

        public Response Create(List<ListNoteParam> param)
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

        public Response Update(long id, ListNoteParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<ListNoteParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(ListNoteParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<ListNoteParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
