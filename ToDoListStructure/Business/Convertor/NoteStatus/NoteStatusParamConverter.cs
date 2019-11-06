using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.NoteStatus
{
    class NoteStatusParamConverter:INoteStatusParamConverter
    {
<<<<<<< Updated upstream
=======
        public INoteStausDao Dao = new NoteStatusDao();

        public Entities.NoteStatus Convert(NoteStatusParam param)
        {
            Entities.NoteStatus entity = new Entities.NoteStatus()
            {
				Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
            };
            return entity;
        }

        public Entities.NoteStatus Convert(NoteStatusParam param, Entities.NoteStatus oldEntity)
        {
            Entities.NoteStatus entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Entities.NoteStatus();
            }

            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
>>>>>>> Stashed changes
    }
}
