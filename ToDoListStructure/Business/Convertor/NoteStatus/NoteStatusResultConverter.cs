using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.NoteStatus
{
    class NoteStatusResultConverter:INoteStatusResultConverter
    {
<<<<<<< Updated upstream
=======
        public NoteStatusResult Convert(Entities.NoteStatus param)
        {
            NoteStatusResult result = new NoteStatusResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
            };
            return result;
        }
>>>>>>> Stashed changes
    }
}
