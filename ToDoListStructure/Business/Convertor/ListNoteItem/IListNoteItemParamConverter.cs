using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.ListNoteItem
{
    interface IListNoteItemParamConverter:IBaseParamConverter<ListNoteItemParam,Data.Entity.ListNoteItem>
    {
		Data.Entity.ListNoteItem Convert(ListNoteItemParam param, Data.Entity.ListNoteItem oldEntity);
    }
}
