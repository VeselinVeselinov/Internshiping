﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor
{
    class BaseParamNamed:BaseParam
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}