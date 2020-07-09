using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public static class GClass3
{
	public static bool smethod_0<FrH9WVDPd5a8lVKrPU>(this IEnumerable<FrH9WVDPd5a8lVKrPU> ienumerable_0, Func<FrH9WVDPd5a8lVKrPU, bool> func_0)
	{
		foreach (FrH9WVDPd5a8lVKrPU arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static bool smethod_1<xK03wmGRjG1JVIlpnv>(this IEnumerable ienumerable_0, Func<xK03wmGRjG1JVIlpnv, bool> func_0)
	{
		foreach (object obj in ienumerable_0)
		{
			xK03wmGRjG1JVIlpnv arg = (xK03wmGRjG1JVIlpnv)((object)obj);
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static int smethod_2<rnle4ku5FhmlynZD7e>(this IEnumerable<rnle4ku5FhmlynZD7e> ienumerable_0, Func<rnle4ku5FhmlynZD7e, bool> func_0)
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
		foreach (rnle4ku5FhmlynZD7e arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	public static string smethod_3<Ibs1LyrExojtMD5IkB>(this IEnumerable<Ibs1LyrExojtMD5IkB> ienumerable_0, Func<Ibs1LyrExojtMD5IkB, string> func_0, string string_0 = ", ")
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (Ibs1LyrExojtMD5IkB arg in ienumerable_0)
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

	public static void smethod_4<uLtctNUZSf3iQmUQwx>(this IEnumerable<uLtctNUZSf3iQmUQwx> ienumerable_0, Action<uLtctNUZSf3iQmUQwx> action_0)
	{
		foreach (uLtctNUZSf3iQmUQwx obj in ienumerable_0)
		{
			action_0(obj);
		}
	}

	public static void smethod_5<hV3qjnaFcedCYS6EaV>(this IEnumerable<hV3qjnaFcedCYS6EaV> ienumerable_0, Action<hV3qjnaFcedCYS6EaV> action_0)
	{
		foreach (hV3qjnaFcedCYS6EaV obj in new List<hV3qjnaFcedCYS6EaV>(ienumerable_0))
		{
			action_0(obj);
		}
	}
}
