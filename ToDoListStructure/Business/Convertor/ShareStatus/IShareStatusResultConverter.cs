using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.ShareStatus
{
    interface IShareStatusResultConverter:IBaseResultConverter<Data.Entity.ShareStatus,ShareStatusResult>
    {
        ShareStatusResult Convert(ToDoListStructure.Data.Entity.ShareStatus param);
    }
}
