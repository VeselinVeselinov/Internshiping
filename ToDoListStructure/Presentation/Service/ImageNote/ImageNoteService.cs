using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ImageNote;
using ToDoListStructure.Business.Processor.ImageNote;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.ImageNote
{
    class ImageNoteService:IImageNoteService
    {
        public IImageNoteProcessor Processor { get; set; }

        public Response Create(ImageNoteParam param)
        {
            throw new NotImplementedException();
        }

        public Response Create(List<ImageNoteParam> param)
        {
            throw new NotImplementedException();
        }

        public Response DeleteByID(long id)
        {
            throw new NotImplementedException();
        }

        public Response Delte(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public Response FindByPK(long id)
        {
            throw new NotImplementedException();
        }

        public Response ListAll()
        {
            throw new NotImplementedException();
        }

        public Response Update(long id, ImageNoteParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<ImageNoteParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(ImageNoteParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<ImageNoteParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
