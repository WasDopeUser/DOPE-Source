using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public static class GClass3
{
	public static bool smethod_0<mZMNssYs3rilgB3bAh>(this IEnumerable<mZMNssYs3rilgB3bAh> ienumerable_0, Func<mZMNssYs3rilgB3bAh, bool> func_0)
	{
		foreach (mZMNssYs3rilgB3bAh arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static bool smethod_1<nJQEsgGjWlnXbH5whU>(this IEnumerable ienumerable_0, Func<nJQEsgGjWlnXbH5whU, bool> func_0)
	{
		foreach (object obj in ienumerable_0)
		{
			nJQEsgGjWlnXbH5whU arg = (nJQEsgGjWlnXbH5whU)((object)obj);
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static int smethod_2<kR8hdoUIj4JqLCIDPd>(this IEnumerable<kR8hdoUIj4JqLCIDPd> ienumerable_0, Func<kR8hdoUIj4JqLCIDPd, bool> func_0)
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
		foreach (kR8hdoUIj4JqLCIDPd arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	public static string smethod_3<anpWba1ayXJHD77QAl>(this IEnumerable<anpWba1ayXJHD77QAl> ienumerable_0, Func<anpWba1ayXJHD77QAl, string> func_0, string string_0 = ", ")
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (anpWba1ayXJHD77QAl arg in ienumerable_0)
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

	public static void xluxvrnbt<EyagwYfGdTsJIhyMdw>(this IEnumerable<EyagwYfGdTsJIhyMdw> ienumerable_0, Action<EyagwYfGdTsJIhyMdw> action_0)
	{
		foreach (EyagwYfGdTsJIhyMdw obj in ienumerable_0)
		{
			action_0(obj);
		}
	}

	public static void smethod_4<tgMmdLQUphvonl6HKd>(this IEnumerable<tgMmdLQUphvonl6HKd> ienumerable_0, Action<tgMmdLQUphvonl6HKd> action_0)
	{
		foreach (tgMmdLQUphvonl6HKd obj in new List<tgMmdLQUphvonl6HKd>(ienumerable_0))
		{
			action_0(obj);
		}
	}
}
