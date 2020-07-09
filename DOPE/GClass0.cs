using System;
using System.Collections.Generic;
using System.Linq;

public static class GClass0
{
	public static ICollection<hWtZ73xq8mIKXTIY0y> smethod_0<hWtZ73xq8mIKXTIY0y>(this ICollection<hWtZ73xq8mIKXTIY0y> icollection_0, Func<hWtZ73xq8mIKXTIY0y, bool> func_0)
	{
		foreach (hWtZ73xq8mIKXTIY0y item in icollection_0.Where(func_0).ToList<hWtZ73xq8mIKXTIY0y>())
		{
			icollection_0.Remove(item);
		}
		return icollection_0;
	}

	public static ICollection<p86ue1K9Gp27jSRIuS> smethod_1<p86ue1K9Gp27jSRIuS>(this ICollection<p86ue1K9Gp27jSRIuS> icollection_0)
	{
		icollection_0.smethod_0(new Func<p86ue1K9Gp27jSRIuS, bool>(GClass0.<>c__1<p86ue1K9Gp27jSRIuS>.<>9.method_0));
		return icollection_0;
	}

	public static void smethod_2<HP9nuoXoOK52vJyl5f>(this ICollection<HP9nuoXoOK52vJyl5f> icollection_0, IEnumerable<HP9nuoXoOK52vJyl5f> ienumerable_0)
	{
		foreach (HP9nuoXoOK52vJyl5f item in ienumerable_0)
		{
			icollection_0.Add(item);
		}
	}
}
