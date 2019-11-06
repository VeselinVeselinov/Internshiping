using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Common
{
	interface IBaseResultConverter<Tin,Tout>
	{
		Tout ConvertStandart(Tin entity,Tout result);

		Tout ConvertSpecific(Tin entity,Tout result);
	}
}
