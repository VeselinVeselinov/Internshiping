﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Share
{
    interface IShareResultConverter
    {
        ShareResult Convert(ToDoListStructure.Entities.Share param);
    }
}
