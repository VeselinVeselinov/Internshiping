using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.DataAccess.Dao.NoteStatus;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.NoteStatus
{
    class NoteStatusParamConverter:BaseParamConverter<NoteStatusParam, Data.Entity.NoteStatus>,INoteStatusParamConverter
    {
		public override Data.Entity.NoteStatus ConvertSpecific(NoteStatusParam param, Data.Entity.NoteStatus entity)
		{
			throw new NotImplementedException();
		}

		public Data.Entity.NoteStatus Convert(NoteStatusParam param, Data.Entity.NoteStatus oldEntity)
        {
			Data.Entity.NoteStatus entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Data.Entity.NoteStatus()
				{
					Id=param.Id,
					Code=param.Code
				};
			}

			entity.Name = param.Name;
			entity.Description = param.Description;

			return entity;
		}
	}
}
