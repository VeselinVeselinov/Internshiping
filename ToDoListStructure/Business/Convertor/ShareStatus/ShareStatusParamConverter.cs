using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ShareStatus
{
    class ShareStatusParamConverter:IShareStatusParamConverter
    {
<<<<<<< Updated upstream
    }
=======
		public IShareStatusDao Dao = new ShareStatusDao();

        public Entities.ShareStatus Convert(ShareStatusParam param)
        {
			Entities.ShareStatus entity = new Entities.ShareStatus()
			{
				Id = param.Id,
				Code = param.Code,
				Name = param.Name,
				Description = param.Description,
			};
			return entity;
		}

		public Entities.ShareStatus Convert(ShareStatusParam param, Entities.ShareStatus oldEntity)
		{
			Entities.ShareStatus entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Entities.ShareStatus();
			}

			entity.Name = param.Name;
			entity.Description = param.Description;

			return entity;
		}
	}
>>>>>>> Stashed changes
}
