using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Presentation.Service.ListNoteItem
{
    interface IListNoteItemService
    {
<<<<<<< Updated upstream
=======
        Response FindByPK(long id);

        Response ListAll();

        Response FindByCode(string code);

        Response FindByName(string name);

        Response Create(ListNoteItemParam param);

        Response Create(List<ListNoteItemParam> param);

        Response Update(long id, ListNoteItemParam param);

        Response Update(List<ListNoteItemParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(ListNoteItemParam param);

        void ValidateParameters(List<ListNoteItemParam> param);
>>>>>>> Stashed changes
    }
}
