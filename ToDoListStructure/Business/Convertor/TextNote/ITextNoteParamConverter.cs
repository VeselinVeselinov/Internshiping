﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.TextNote
{
    interface ITextNoteParamConverter
    {
        ToDoListStructure.Data.Entity.TextNote Convert(TextNoteParam param);
    }
}
