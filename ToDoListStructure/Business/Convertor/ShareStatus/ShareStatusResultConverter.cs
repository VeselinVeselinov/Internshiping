using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.ShareStatus
{
    class ShareStatusResultConverter : BaseResultConverter<Data.Entity.ShareStatus,ShareStatusResult>,IShareStatusResultConverter
    {
		public override ShareStatusResult ConvertSpecific(Data.Entity.ShareStatus entity, ShareStatusResult result)
		{
			throw new NotImplementedException();
		}

		public ShareStatusResult Convert(Data.Entity.ShareStatus param)
        {
			ShareStatusResult result = ConvertStandart(param, new ShareStatusResult());
			return result;
        }
	}
}
