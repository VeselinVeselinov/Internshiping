using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Share
{
    interface IShareResultConverter:IBaseResultConverter<Data.Entity.Share,ShareResult>
    {
        ShareResult Convert(ToDoListStructure.Data.Entity.Share param);
    }
}
