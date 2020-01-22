using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public static class GClass3
{
	public static bool smethod_0<OUTLUKO2GgCNk8SOFn>(this IEnumerable<OUTLUKO2GgCNk8SOFn> ienumerable_0, Func<OUTLUKO2GgCNk8SOFn, bool> func_0)
	{
		foreach (OUTLUKO2GgCNk8SOFn arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static bool smethod_1<y8kjRGp7VFdetYrNxX>(this IEnumerable ienumerable_0, Func<y8kjRGp7VFdetYrNxX, bool> func_0)
	{
		foreach (object obj in ienumerable_0)
		{
			y8kjRGp7VFdetYrNxX arg = (y8kjRGp7VFdetYrNxX)((object)obj);
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static int smethod_2<HfJAhGN9nokLHuf52e>(this IEnumerable<HfJAhGN9nokLHuf52e> ienumerable_0, Func<HfJAhGN9nokLHuf52e, bool> func_0)
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
		foreach (HfJAhGN9nokLHuf52e arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	public static string smethod_3<LMmTxlAk8GbFVmCcRd>(this IEnumerable<LMmTxlAk8GbFVmCcRd> ienumerable_0, Func<LMmTxlAk8GbFVmCcRd, string> func_0, string string_0 = ", ")
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (LMmTxlAk8GbFVmCcRd arg in ienumerable_0)
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

	public static void smethod_4<JNpRkRGIdJwVmEkS1A>(this IEnumerable<JNpRkRGIdJwVmEkS1A> ienumerable_0, Action<JNpRkRGIdJwVmEkS1A> action_0)
	{
		foreach (JNpRkRGIdJwVmEkS1A obj in ienumerable_0)
		{
			action_0(obj);
		}
	}

	public static void smethod_5<fAK9hdwmFqi5umjcIA>(this IEnumerable<fAK9hdwmFqi5umjcIA> ienumerable_0, Action<fAK9hdwmFqi5umjcIA> action_0)
	{
		foreach (fAK9hdwmFqi5umjcIA obj in new List<fAK9hdwmFqi5umjcIA>(ienumerable_0))
		{
			action_0(obj);
		}
	}
}
