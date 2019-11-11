using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Common
{
	interface IBaseParamConverter<TParam,TEntity>
	{
		TEntity ConvertStandart(TParam param, TEntity entity);

		TEntity ConvertSpecific(TParam param, TEntity entity);
	}
}
