using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Presentation.JsonConverter
{
    static class JsonConverter
    {
        public static string ObjToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
