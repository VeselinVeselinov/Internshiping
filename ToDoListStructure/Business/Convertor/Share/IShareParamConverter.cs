using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Share
{
    interface IShareParamConverter:IBaseParamConverter<ShareParam,Data.Entity.Share>
    {
        ToDoListStructure.Data.Entity.Share Convert(ShareParam param,Data.Entity.Share oldEntity);
    }
}
