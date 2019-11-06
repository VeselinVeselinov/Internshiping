using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Share
{
    class ShareParamConverter:IShareParamConverter
    {
<<<<<<< Updated upstream
    }
=======
        public IShareDao Dao { get; set; }

        public Entities.Share Convert(ShareParam param)
        {
			Entities.Share entity = new Entities.Share()
			{
				Id = param.Id,
				Contributor=param.Contributor,
				Owner=param.Owner,
				Note=param.Note,
				Status=param.Status
			};
			return entity;
		}

		public Entities.Share Convert(ShareParam param, Entities.Share oldEntity)
		{
			Entities.Share entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Entities.Share();
			}

			entity.Contributor = param.Contributor;
			entity.Owner = param.Owner;
			entity.Note = param.Note;
			entity.Status = param.Status;

			return entity;
		}
	}
>>>>>>> Stashed changes
}
