using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ListNote
{
    interface IListNoteParamConverter
    {
        ToDoListStructure.Entities.ListNote Convert(ListNoteParam param);
    }
}
