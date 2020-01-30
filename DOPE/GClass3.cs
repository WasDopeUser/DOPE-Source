using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public static class GClass3
{
	public static bool smethod_0<kXi5oHQYW3anvOP0Id>(this IEnumerable<kXi5oHQYW3anvOP0Id> ienumerable_0, Func<kXi5oHQYW3anvOP0Id, bool> func_0)
	{
		foreach (kXi5oHQYW3anvOP0Id arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static bool smethod_1<H0K2KaHlpqDHVWZslk>(this IEnumerable ienumerable_0, Func<H0K2KaHlpqDHVWZslk, bool> func_0)
	{
		foreach (object obj in ienumerable_0)
		{
			H0K2KaHlpqDHVWZslk arg = (H0K2KaHlpqDHVWZslk)((object)obj);
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static int smethod_2<ru55tfKEiFFcdZNL3q>(this IEnumerable<ru55tfKEiFFcdZNL3q> ienumerable_0, Func<ru55tfKEiFFcdZNL3q, bool> func_0)
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
		foreach (ru55tfKEiFFcdZNL3q arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	public static string smethod_3<IUjIcRkcN7rm2xvCt2>(this IEnumerable<IUjIcRkcN7rm2xvCt2> ienumerable_0, Func<IUjIcRkcN7rm2xvCt2, string> func_0, string string_0 = ", ")
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (IUjIcRkcN7rm2xvCt2 arg in ienumerable_0)
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

	public static void smethod_4<n4jVxnhLtAaGIo2RcN>(this IEnumerable<n4jVxnhLtAaGIo2RcN> ienumerable_0, Action<n4jVxnhLtAaGIo2RcN> action_0)
	{
		foreach (n4jVxnhLtAaGIo2RcN obj in ienumerable_0)
		{
			action_0(obj);
		}
	}

	public static void smethod_5<BofxraLDIwTPN2Cm1Z>(this IEnumerable<BofxraLDIwTPN2Cm1Z> ienumerable_0, Action<BofxraLDIwTPN2Cm1Z> action_0)
	{
		foreach (BofxraLDIwTPN2Cm1Z obj in new List<BofxraLDIwTPN2Cm1Z>(ienumerable_0))
		{
			action_0(obj);
		}
	}
}
