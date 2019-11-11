using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common.CustomAttributes;

namespace ToDoListStructure.Business.Convertor.Common
{
    abstract class BaseParam
    {
		[Ignore]
        public long Id { get; set; }
    }
}
