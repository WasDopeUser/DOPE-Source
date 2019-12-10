using System;
using ProtoBuf;

namespace DOPE.Common
{
	public static class DataUtils
	{
		public static T DeepClone<T>(T obj)
		{
			return Serializer.DeepClone<T>(obj);
		}

		public static string ToPascal(this string s)
		{
			if (string.IsNullOrWhiteSpace(s))
			{
				return s;
			}
			if (s.Length == 1)
			{
				return char.ToUpper(s[0]).ToString();
			}
			return char.ToUpper(s[0]).ToString() + s.Substring(1);
		}
	}
}
