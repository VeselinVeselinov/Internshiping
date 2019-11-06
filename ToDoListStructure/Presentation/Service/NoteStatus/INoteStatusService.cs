using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Presentation.Service.NoteStatus
{
    interface INoteStatusService
    {
<<<<<<< Updated upstream
=======
        Response FindByPK(long id);

        Response ListAll();

        Response FindByCode(string code);

        Response FindByName(string name);

        Response Create(NoteStatusParam param);

        Response Create(List<NoteStatusParam> param);

        Response Update(long id, NoteStatusParam param);

        Response Update(List<NoteStatusParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(NoteStatusParam param);

        void ValidateParameters(List<NoteStatusParam> param);
>>>>>>> Stashed changes
    }
}
