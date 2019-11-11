using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.TextNote;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.TextNote
{
    interface ITextNoteService
    {
        Response FindByPK(long id);

        Response ListAll();

        Response Create(TextNoteParam param);

        Response Create(List<TextNoteParam> param);

        Response Update(long id, TextNoteParam param);

        Response Update(List<TextNoteParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(TextNoteParam param);

        void ValidateParameters(List<TextNoteParam> param);
    }
}
