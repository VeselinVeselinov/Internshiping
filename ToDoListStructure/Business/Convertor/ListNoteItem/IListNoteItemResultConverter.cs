using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.ListNoteItem
{
    interface IListNoteItemResultConverter:IBaseResultConverter<Data.Entity.ListNoteItem, ListNoteItemResult>
    {
        ListNoteItemResult Convert(ToDoListStructure.Data.Entity.ListNoteItem param);
    }
}
