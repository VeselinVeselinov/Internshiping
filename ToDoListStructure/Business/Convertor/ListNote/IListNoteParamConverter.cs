using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ListNote
{
    interface IListNoteParamConverter
    {
        ToDoListStructure.Data.Entity.ListNote Convert(ListNoteParam param);
    }
}
