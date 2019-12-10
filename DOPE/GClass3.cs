using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public static class GClass3
{
	public static bool smethod_0<gs96OvISrHjZL4hwta>(this IEnumerable<gs96OvISrHjZL4hwta> ienumerable_0, Func<gs96OvISrHjZL4hwta, bool> func_0)
	{
		foreach (gs96OvISrHjZL4hwta arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static bool smethod_1<Mayfh32E9k99Nx2IkC>(this IEnumerable ienumerable_0, Func<Mayfh32E9k99Nx2IkC, bool> func_0)
	{
		foreach (object obj in ienumerable_0)
		{
			Mayfh32E9k99Nx2IkC arg = (Mayfh32E9k99Nx2IkC)((object)obj);
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static int smethod_2<axnGPnEOvR4ZgJPRg3>(this IEnumerable<axnGPnEOvR4ZgJPRg3> ienumerable_0, Func<axnGPnEOvR4ZgJPRg3, bool> func_0)
	{
		if (ienumerable_0 == null)
		{
			throw new ArgumentNullException("items");
		}
		if (func_0 == null)
		{
			throw new ArgumentNullException("predicate");
		}
		int num = 0;
		foreach (axnGPnEOvR4ZgJPRg3 arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	public static string smethod_3<NisPOQb7KOJIFhK5TU>(this IEnumerable<NisPOQb7KOJIFhK5TU> ienumerable_0, Func<NisPOQb7KOJIFhK5TU, string> func_0, string string_0 = ", ")
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (NisPOQb7KOJIFhK5TU arg in ienumerable_0)
		{
			if (flag)
			{
				flag = false;
			}
			else if (string_0 != null)
			{
				stringBuilder.Append(string_0);
			}
			stringBuilder.Append(func_0(arg));
		}
		return stringBuilder.ToString();
	}

	public static void smethod_4<R8ceS6uf3vogJILNle>(this IEnumerable<R8ceS6uf3vogJILNle> ienumerable_0, Action<R8ceS6uf3vogJILNle> action_0)
	{
		foreach (R8ceS6uf3vogJILNle obj in ienumerable_0)
		{
			action_0(obj);
		}
	}

	public static void smethod_5<a2mbw0Si2ZIOw2G5hF>(this IEnumerable<a2mbw0Si2ZIOw2G5hF> ienumerable_0, Action<a2mbw0Si2ZIOw2G5hF> action_0)
	{
		foreach (a2mbw0Si2ZIOw2G5hF obj in new List<a2mbw0Si2ZIOw2G5hF>(ienumerable_0))
		{
			action_0(obj);
		}
	}
}
