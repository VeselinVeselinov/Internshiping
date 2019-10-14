using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ImageNote;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.ImageNote
{
    interface IImageNoteService
    {
        Response FindByPK(long id);

        Response ListAll();

        Response Create(ImageNoteParam param);

        Response Create(List<ImageNoteParam> param);

        Response Update(long id, ImageNoteParam param);

        Response Update(List<ImageNoteParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(ImageNoteParam param);

        void ValidateParameters(List<ImageNoteParam> param);
    }
}
