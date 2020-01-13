using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public static class GClass3
{
	public static bool smethod_0<CpNhDGuvUjIav6YKsZ>(this IEnumerable<CpNhDGuvUjIav6YKsZ> ienumerable_0, Func<CpNhDGuvUjIav6YKsZ, bool> func_0)
	{
		foreach (CpNhDGuvUjIav6YKsZ arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static bool smethod_1<Qpg5OBt8pesIQFEr21>(this IEnumerable ienumerable_0, Func<Qpg5OBt8pesIQFEr21, bool> func_0)
	{
		foreach (object obj in ienumerable_0)
		{
			Qpg5OBt8pesIQFEr21 arg = (Qpg5OBt8pesIQFEr21)((object)obj);
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static int smethod_2<Bp8auj0pTX5LxO70UG>(this IEnumerable<Bp8auj0pTX5LxO70UG> ienumerable_0, Func<Bp8auj0pTX5LxO70UG, bool> func_0)
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
		foreach (Bp8auj0pTX5LxO70UG arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	public static string smethod_3<ORKXv5DEKQmXSWTeU5>(this IEnumerable<ORKXv5DEKQmXSWTeU5> ienumerable_0, Func<ORKXv5DEKQmXSWTeU5, string> func_0, string string_0 = ", ")
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (ORKXv5DEKQmXSWTeU5 arg in ienumerable_0)
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

	public static void smethod_4<MdL6py5g3vWl1JFFx3>(this IEnumerable<MdL6py5g3vWl1JFFx3> ienumerable_0, Action<MdL6py5g3vWl1JFFx3> action_0)
	{
		foreach (MdL6py5g3vWl1JFFx3 obj in ienumerable_0)
		{
			action_0(obj);
		}
	}

	public static void smethod_5<OHH4GFLTqwE7vn6axt>(this IEnumerable<OHH4GFLTqwE7vn6axt> ienumerable_0, Action<OHH4GFLTqwE7vn6axt> action_0)
	{
		foreach (OHH4GFLTqwE7vn6axt obj in new List<OHH4GFLTqwE7vn6axt>(ienumerable_0))
		{
			action_0(obj);
		}
	}
}
