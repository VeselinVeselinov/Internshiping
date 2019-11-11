using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common.CustomAttributes;

namespace ToDoListStructure.Business.Convertor.Common
{
    class BaseParamNamed:BaseParam
    {
		[Ignore]
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
