using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Common
{
	interface IBaseResultConverter<TEntity, TResult>
	{
		TResult ConvertStandart(TEntity entity, TResult result);

		TResult ConvertSpecific(TEntity entity, TResult result);
	}
}
