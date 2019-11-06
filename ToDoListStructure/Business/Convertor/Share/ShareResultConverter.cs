using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Share
{
    class ShareResultConverter:IShareResultConverter
    {
<<<<<<< Updated upstream
=======
        public ShareResult Convert(Entities.Share param)
        {
			ShareResult result = new ShareResult()
			{
				Id = param.Id,
				Owner=param.Owner,
				Contributor=param.Contributor,
				Note=param.Note,
				Status=param.Status
			};
			return result;
		}
>>>>>>> Stashed changes
    }
}
