using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Common
{
	abstract class BaseResultConverter<TEntity, TResult> : IBaseResultConverter<TEntity, TResult>
	{
		public abstract TResult ConvertSpecific(TEntity entity, TResult result);

		public TResult ConvertStandart(TEntity entity, TResult result)
		{
			Dictionary<string, PropertyInfo> entityInfo = entity.GetType()
															.GetProperties()
																.ToDictionary(prop => prop.Name, prop => prop);

			foreach (var entityPair in entityInfo)
			{
				if (result.GetType().GetProperty(entityPair.Key) != null)
				{
					result.GetType().GetProperty(entityPair.Key).SetValue(result, entityPair.Value.GetValue(entity));
				}
			}

			return result;
		}
	}
}
