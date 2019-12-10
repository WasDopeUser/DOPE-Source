using System;
using System.ComponentModel.DataAnnotations;

namespace DOPE.Common
{
	public static class EnumExtensions
	{
		public static string GetName(this Enum value)
		{
			DisplayAttribute displayAttribute = value.smethod_1<DisplayAttribute>();
			if (displayAttribute != null)
			{
				return displayAttribute.Name;
			}
			return value.ToString();
		}
	}
}
