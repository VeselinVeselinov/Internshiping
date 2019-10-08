using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ListNoteItem;
using ToDoListStructure.DataAccess.Dao.ListNoteItem;

namespace ToDoListStructure.Business.Processor.ListNoteItem
{
    class ListNoteItemProcessor:IListNoteItemProcessor
    {
        public ListNoteItemDao Dao { get; set; }

        public ListNoteItemParamConverter ParamConverter { get; set; }

        public ListNoteItemResultConverter ResultConverter { get; set; }
    }
}
