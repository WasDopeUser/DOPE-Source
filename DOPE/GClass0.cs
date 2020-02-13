using System;
using System.Collections.Generic;
using System.Linq;

public static class GClass0
{
	public static ICollection<tRdEUP15TaQXKhNGyU> smethod_0<tRdEUP15TaQXKhNGyU>(this ICollection<tRdEUP15TaQXKhNGyU> icollection_0, Func<tRdEUP15TaQXKhNGyU, bool> func_0)
	{
		foreach (tRdEUP15TaQXKhNGyU item in icollection_0.Where(func_0).ToList<tRdEUP15TaQXKhNGyU>())
		{
			icollection_0.Remove(item);
		}
		return icollection_0;
	}

	public static ICollection<BxLfjePqqlk5D0Qs8P> smethod_1<BxLfjePqqlk5D0Qs8P>(this ICollection<BxLfjePqqlk5D0Qs8P> icollection_0)
	{
		icollection_0.smethod_0(new Func<BxLfjePqqlk5D0Qs8P, bool>(GClass0.<>c__1<BxLfjePqqlk5D0Qs8P>.<>9.method_0));
		return icollection_0;
	}

	public static void smethod_2<XCe8HIqK69s2IGm3fb>(this ICollection<XCe8HIqK69s2IGm3fb> icollection_0, IEnumerable<XCe8HIqK69s2IGm3fb> ienumerable_0)
	{
		foreach (XCe8HIqK69s2IGm3fb item in ienumerable_0)
		{
			icollection_0.Add(item);
		}
	}
}
