using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Common
{
	interface IBaseParamConverter<TIn,TOut>
	{
		TOut ConvertStandart(TIn param,TOut entity);

		TOut ConvertSpecific(TIn param, TOut entity);
	}
}
