using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ListNoteItem;
using ToDoListStructure.Business.Processor.ListNoteItem;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.ListNoteItem
{
    class ListNoteItemService:IListNoteItemService
    {
        public IListNoteItemProcessor Processor { get; set; }

        public Response Create(ListNoteItemParam param)
        {
            throw new NotImplementedException();
        }

        public Response Create(List<ListNoteItemParam> param)
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

        public Response Update(long id, ListNoteItemParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<ListNoteItemParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(ListNoteItemParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<ListNoteItemParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
