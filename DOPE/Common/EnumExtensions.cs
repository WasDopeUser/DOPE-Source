using System;
using System.ComponentModel.DataAnnotations;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;

namespace DOPE.Common
{
	public static class EnumExtensions
	{
		public static string GetName(this Enum value)
		{
			DisplayAttribute displayAttribute = value.smethod_0<DisplayAttribute>();
			if (displayAttribute != null)
			{
				return displayAttribute.Name;
			}
			return value.ToString();
		}

		public static string GetName(this TargetMap value)
		{
			MapAttribute mapAttribute = value.smethod_0<MapAttribute>();
			if (mapAttribute != null)
			{
				return mapAttribute.Name;
			}
			return value.ToString();
		}

		public static int Resolve(this TargetMap value, int factionId)
		{
			MapAttribute mapAttribute = value.smethod_0<MapAttribute>();
			if (mapAttribute != null && mapAttribute.ByFaction != 0)
			{
				return MapUtils.smethod_12(mapAttribute.ByFaction, factionId);
			}
			return (int)value;
		}
	}
}
