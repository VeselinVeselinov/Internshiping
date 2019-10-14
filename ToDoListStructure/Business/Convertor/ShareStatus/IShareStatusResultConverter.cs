using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ShareStatus
{
    interface IShareStatusResultConverter
    {
        ShareStatusResult Convert(ToDoListStructure.Entities.ShareStatus param);
    }
}
