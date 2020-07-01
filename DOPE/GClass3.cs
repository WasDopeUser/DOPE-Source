using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public static class GClass3
{
	public static bool smethod_0<KMLMuJm7Dc97vrBHPu>(this IEnumerable<KMLMuJm7Dc97vrBHPu> ienumerable_0, Func<KMLMuJm7Dc97vrBHPu, bool> func_0)
	{
		foreach (KMLMuJm7Dc97vrBHPu arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static bool smethod_1<hKQc9yrwD0LkO3qajP>(this IEnumerable ienumerable_0, Func<hKQc9yrwD0LkO3qajP, bool> func_0)
	{
		foreach (object obj in ienumerable_0)
		{
			hKQc9yrwD0LkO3qajP arg = (hKQc9yrwD0LkO3qajP)((object)obj);
			if (func_0(arg))
			{
				return true;
			}
		}
		return false;
	}

	public static int smethod_2<UUh66EJbF7BGCvARwx>(this IEnumerable<UUh66EJbF7BGCvARwx> ienumerable_0, Func<UUh66EJbF7BGCvARwx, bool> func_0)
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
		foreach (UUh66EJbF7BGCvARwx arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	public static string smethod_3<p4HcJQ9ZmAPQ3JRYkW>(this IEnumerable<p4HcJQ9ZmAPQ3JRYkW> ienumerable_0, Func<p4HcJQ9ZmAPQ3JRYkW, string> func_0, string string_0 = ", ")
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (p4HcJQ9ZmAPQ3JRYkW arg in ienumerable_0)
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

	public static void smethod_4<CWIHlwerPU3XorD7T2>(this IEnumerable<CWIHlwerPU3XorD7T2> ienumerable_0, Action<CWIHlwerPU3XorD7T2> action_0)
	{
		foreach (CWIHlwerPU3XorD7T2 obj in ienumerable_0)
		{
			action_0(obj);
		}
	}

	public static void smethod_5<KNwTUPhZ5twwC3AFmy>(this IEnumerable<KNwTUPhZ5twwC3AFmy> ienumerable_0, Action<KNwTUPhZ5twwC3AFmy> action_0)
	{
		foreach (KNwTUPhZ5twwC3AFmy obj in new List<KNwTUPhZ5twwC3AFmy>(ienumerable_0))
		{
			action_0(obj);
		}
	}
}
