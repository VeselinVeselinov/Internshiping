using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Common
{
	abstract class BaseResultConverter<Tin, Tout> : IBaseResultConverter<Tin, Tout>
	{
		public abstract Tout ConvertSpecific(Tin entity, Tout result);

		public Tout ConvertStandart(Tin entity, Tout result)
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
