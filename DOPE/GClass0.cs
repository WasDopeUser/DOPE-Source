using System;
using System.Collections.Generic;
using System.Linq;

public static class GClass0
{
	public static ICollection<ItCgoF0AE8ebMbcOgk> smethod_0<ItCgoF0AE8ebMbcOgk>(this ICollection<ItCgoF0AE8ebMbcOgk> icollection_0, Func<ItCgoF0AE8ebMbcOgk, bool> func_0)
	{
		foreach (ItCgoF0AE8ebMbcOgk item in icollection_0.Where(func_0).ToList<ItCgoF0AE8ebMbcOgk>())
		{
			icollection_0.Remove(item);
		}
		return icollection_0;
	}

	public static ICollection<SUmZNrMTMjgeOJf2C3> wkhfEkrKw<SUmZNrMTMjgeOJf2C3>(this ICollection<SUmZNrMTMjgeOJf2C3> icollection_0)
	{
		icollection_0.smethod_0(new Func<SUmZNrMTMjgeOJf2C3, bool>(GClass0.<>c__1<SUmZNrMTMjgeOJf2C3>.<>9.method_0));
		return icollection_0;
	}

	public static void smethod_1<XLBeVXqHmQF65MviSG>(this ICollection<XLBeVXqHmQF65MviSG> icollection_0, IEnumerable<XLBeVXqHmQF65MviSG> ienumerable_0)
	{
		foreach (XLBeVXqHmQF65MviSG item in ienumerable_0)
		{
			icollection_0.Add(item);
		}
	}
}
