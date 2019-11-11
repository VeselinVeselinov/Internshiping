using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ToDoListStructure.Business.Convertor.Common.CustomAttributes;

namespace ToDoListStructure.Business.Convertor.Common
{
	abstract class BaseParamConverter<TParam, TEntity> : IBaseParamConverter<TParam, TEntity>
	{
		abstract public TEntity ConvertSpecific(TParam param, TEntity entity);

		public TEntity ConvertStandart(TParam param, TEntity entity)
		{
			IDictionary<string,PropertyInfo> paramInfo = param.GetType()
																.GetProperties()
																	.Where(prop=>prop.GetCustomAttribute(typeof(Ignore)) == null)
																		.ToDictionary(paramProp=>paramProp.Name,paramProp=>paramProp);

			foreach (var paramPair in paramInfo)
			{
				if (entity.GetType().GetProperty(paramPair.Key)!=null)
				{
					entity.GetType().GetProperty(paramPair.Key).SetValue(entity,paramPair.Value.GetValue(param));
				}
			}

			return entity;
		}
	}
}
