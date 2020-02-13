using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public static class GClass3
{
	public static bool smethod_0<i8ofWf97RTK9Nu8W0x>(this IEnumerable<i8ofWf97RTK9Nu8W0x> ienumerable_0, Func<i8ofWf97RTK9Nu8W0x, bool> func_0)
	{
		foreach (i8ofWf97RTK9Nu8W0x arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static bool smethod_1<fm6FySRmh0XKaAaB4d>(this IEnumerable ienumerable_0, Func<fm6FySRmh0XKaAaB4d, bool> func_0)
	{
		foreach (object obj in ienumerable_0)
		{
			fm6FySRmh0XKaAaB4d arg = (fm6FySRmh0XKaAaB4d)((object)obj);
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static int smethod_2<ENMW2QtUORkBRQZIpW>(this IEnumerable<ENMW2QtUORkBRQZIpW> ienumerable_0, Func<ENMW2QtUORkBRQZIpW, bool> func_0)
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
		foreach (ENMW2QtUORkBRQZIpW arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	public static string smethod_3<xkvZXKHPPhH6BjnCuC>(this IEnumerable<xkvZXKHPPhH6BjnCuC> ienumerable_0, Func<xkvZXKHPPhH6BjnCuC, string> func_0, string string_0 = ", ")
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (xkvZXKHPPhH6BjnCuC arg in ienumerable_0)
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

	public static void smethod_4<EEDWXZXmFnPZwxEYFQ>(this IEnumerable<EEDWXZXmFnPZwxEYFQ> ienumerable_0, Action<EEDWXZXmFnPZwxEYFQ> action_0)
	{
		foreach (EEDWXZXmFnPZwxEYFQ obj in ienumerable_0)
		{
			action_0(obj);
		}
	}

	public static void smethod_5<TvIsNVuOR9eNZkQMiH>(this IEnumerable<TvIsNVuOR9eNZkQMiH> ienumerable_0, Action<TvIsNVuOR9eNZkQMiH> action_0)
	{
		foreach (TvIsNVuOR9eNZkQMiH obj in new List<TvIsNVuOR9eNZkQMiH>(ienumerable_0))
		{
			action_0(obj);
		}
	}
}
