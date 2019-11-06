using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ShareStatus
{
    class ShareStatusResultConverter:IShareStatusResultConverter
    {
<<<<<<< Updated upstream
=======
        public ShareStatusResult Convert(Entities.ShareStatus param)
        {
			ShareStatusResult result = new ShareStatusResult()
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
