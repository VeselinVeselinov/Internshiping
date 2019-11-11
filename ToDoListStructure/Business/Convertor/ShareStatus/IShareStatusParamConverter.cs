using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.ShareStatus
{
    interface IShareStatusParamConverter:IBaseParamConverter<ShareStatusParam,Data.Entity.ShareStatus>
    {
        ToDoListStructure.Data.Entity.ShareStatus Convert(ShareStatusParam param,Data.Entity.ShareStatus oldEntity);
    }
}
