using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Presentation.Service.ImageNote
{
    interface IImageNoteService
    {
<<<<<<< Updated upstream
=======
        Response FindByPK(long id);

        Response ListAll();

        Response FindByCode(string code);

        Response FindByName(string name);

        Response Create(ImageNoteParam param);

        Response Create(List<ImageNoteParam> param);

        Response Update(long id, ImageNoteParam param);

        Response Update(List<ImageNoteParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(ImageNoteParam param);

        void ValidateParameters(List<ImageNoteParam> param);
>>>>>>> Stashed changes
    }
}
