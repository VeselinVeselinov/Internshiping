using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ListNoteItem;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.ListNoteItem
{
    interface IListNoteItemService
    {
        Response FindByPK(long id);

        Response ListAll();

        Response Create(ListNoteItemParam param);

        Response Create(List<ListNoteItemParam> param);

        Response Update(long id, ListNoteItemParam param);

        Response Update(List<ListNoteItemParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(ListNoteItemParam param);

        void ValidateParameters(List<ListNoteItemParam> param);
    }
}
