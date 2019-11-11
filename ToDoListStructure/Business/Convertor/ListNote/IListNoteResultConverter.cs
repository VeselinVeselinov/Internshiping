using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ListNote
{
    interface IListNoteResultConverter
    {
        ListNoteResult Convert(ToDoListStructure.Data.Entity.ListNote param);
    }
}
