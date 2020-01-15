using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public static class GClass3
{
	public static bool smethod_0<P1CpnUptK6qFQqX5Bq>(this IEnumerable<P1CpnUptK6qFQqX5Bq> ienumerable_0, Func<P1CpnUptK6qFQqX5Bq, bool> func_0)
	{
		foreach (P1CpnUptK6qFQqX5Bq arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static bool smethod_1<l8ihdaE7aZ1ldH4V0b>(this IEnumerable ienumerable_0, Func<l8ihdaE7aZ1ldH4V0b, bool> func_0)
	{
		foreach (object obj in ienumerable_0)
		{
			l8ihdaE7aZ1ldH4V0b arg = (l8ihdaE7aZ1ldH4V0b)((object)obj);
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static int smethod_2<HvdGaoJAGcocZrCmDL>(this IEnumerable<HvdGaoJAGcocZrCmDL> ienumerable_0, Func<HvdGaoJAGcocZrCmDL, bool> func_0)
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
		foreach (HvdGaoJAGcocZrCmDL arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	public static string smethod_3<Fh91exoVNTAp4SUaM1>(this IEnumerable<Fh91exoVNTAp4SUaM1> ienumerable_0, Func<Fh91exoVNTAp4SUaM1, string> func_0, string string_0 = ", ")
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (Fh91exoVNTAp4SUaM1 arg in ienumerable_0)
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

	public static void smethod_4<HUYl5UeJObhjBdgPkk>(this IEnumerable<HUYl5UeJObhjBdgPkk> ienumerable_0, Action<HUYl5UeJObhjBdgPkk> action_0)
	{
		foreach (HUYl5UeJObhjBdgPkk obj in ienumerable_0)
		{
			action_0(obj);
		}
	}

	public static void smethod_5<ccEH4vUIfl6Dlad7aM>(this IEnumerable<ccEH4vUIfl6Dlad7aM> ienumerable_0, Action<ccEH4vUIfl6Dlad7aM> action_0)
	{
		foreach (ccEH4vUIfl6Dlad7aM obj in new List<ccEH4vUIfl6Dlad7aM>(ienumerable_0))
		{
			action_0(obj);
		}
	}
}
