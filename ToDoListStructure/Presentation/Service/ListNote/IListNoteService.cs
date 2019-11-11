using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ListNote;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.ListNote
{
    interface IListNoteService
    {
        Response FindByPK(long id);

        Response ListAll();

        Response Create(ListNoteParam param);

        Response Create(List<ListNoteParam> param);

        Response Update(long id, ListNoteParam param);

        Response Update(List<ListNoteParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(ListNoteParam param);

        void ValidateParameters(List<ListNoteParam> param);
    }
}
