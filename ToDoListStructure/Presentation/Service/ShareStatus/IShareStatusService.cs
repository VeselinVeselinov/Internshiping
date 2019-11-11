using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ShareStatus;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.ShareStatus
{
    interface IShareStatusService
    {
		Response FindByPK(long id);

		Response ListAll();

		Response FindByCode(string code);

		Response FindByName(string name);

		Response FindByAttribute(string att,string value);

		Response Create(ShareStatusParam param);

		Response Create(List<ShareStatusParam> param);

		Response Update(long id, ShareStatusParam param);

		Response Update(List<ShareStatusParam> param);

		Response DeleteByID(long id);

		Response Delte(List<long> idList);

		void ValidateParameters(ShareStatusParam param);

		void ValidateParameters(List<ShareStatusParam> param);
	}
}
