using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Share;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.Share
{
    interface IShareService
    {
		Response FindByPK(long id);

		Response ListAll();

		Response Create(ShareParam param);

		Response Create(List<ShareParam> param);

		Response Update(long id, ShareParam param);

		Response Update(List<ShareParam> param);

		Response DeleteByID(long id);

		Response Delte(List<long> idList);

		void ValidateParameters(ShareParam param);

		void ValidateParameters(List<ShareParam> param);
	}
}
