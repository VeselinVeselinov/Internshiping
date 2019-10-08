using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.ListNoteItem;

namespace ToDoListStructure.Presentation.Service.ListNoteItem
{
    class ListNoteItemService:IListNoteItemService
    {
        public ListNoteItemProcessor Processor { get; set; }
    }
}
