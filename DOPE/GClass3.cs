using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public static class GClass3
{
	public static bool smethod_0<aeYBosWbyjT5x5w8kK>(this IEnumerable<aeYBosWbyjT5x5w8kK> ienumerable_0, Func<aeYBosWbyjT5x5w8kK, bool> func_0)
	{
		foreach (aeYBosWbyjT5x5w8kK arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static bool tpImDwgt4<sUMs8ENu09n77rtowE>(this IEnumerable ienumerable_0, Func<sUMs8ENu09n77rtowE, bool> func_0)
	{
		foreach (object obj in ienumerable_0)
		{
			sUMs8ENu09n77rtowE arg = (sUMs8ENu09n77rtowE)((object)obj);
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static int smethod_1<GA4DFoF5hod29n4xy0>(this IEnumerable<GA4DFoF5hod29n4xy0> ienumerable_0, Func<GA4DFoF5hod29n4xy0, bool> func_0)
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
		foreach (GA4DFoF5hod29n4xy0 arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	public static string smethod_2<RkhKTMpX58FPHra07S>(this IEnumerable<RkhKTMpX58FPHra07S> ienumerable_0, Func<RkhKTMpX58FPHra07S, string> func_0, string string_0 = ", ")
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (RkhKTMpX58FPHra07S arg in ienumerable_0)
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

	public static void smethod_3<r1RAKLA7vSur6fQgQQ>(this IEnumerable<r1RAKLA7vSur6fQgQQ> ienumerable_0, Action<r1RAKLA7vSur6fQgQQ> action_0)
	{
		foreach (r1RAKLA7vSur6fQgQQ obj in ienumerable_0)
		{
			action_0(obj);
		}
	}

	public static void smethod_4<rviRCvTDuNU8tQmRcU>(this IEnumerable<rviRCvTDuNU8tQmRcU> ienumerable_0, Action<rviRCvTDuNU8tQmRcU> action_0)
	{
		foreach (rviRCvTDuNU8tQmRcU obj in new List<rviRCvTDuNU8tQmRcU>(ienumerable_0))
		{
			action_0(obj);
		}
	}
}
