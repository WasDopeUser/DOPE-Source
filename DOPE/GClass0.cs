using System;
using System.Collections.Generic;
using System.Linq;

public static class GClass0
{
	public static ICollection<yJmlw22oRnrO3r8btF> smethod_0<yJmlw22oRnrO3r8btF>(this ICollection<yJmlw22oRnrO3r8btF> icollection_0, Func<yJmlw22oRnrO3r8btF, bool> func_0)
	{
		foreach (yJmlw22oRnrO3r8btF item in icollection_0.Where(func_0).ToList<yJmlw22oRnrO3r8btF>())
		{
			icollection_0.Remove(item);
		}
		return icollection_0;
	}

	public static ICollection<RmtbGANkcm71l4k6EA> smethod_1<RmtbGANkcm71l4k6EA>(this ICollection<RmtbGANkcm71l4k6EA> icollection_0)
	{
		icollection_0.smethod_0(new Func<RmtbGANkcm71l4k6EA, bool>(GClass0.<>c__1<RmtbGANkcm71l4k6EA>.<>9.method_0));
		return icollection_0;
	}

	public static void smethod_2<CwRwp3sukF90MZsVpU>(this ICollection<CwRwp3sukF90MZsVpU> icollection_0, IEnumerable<CwRwp3sukF90MZsVpU> ienumerable_0)
	{
		foreach (CwRwp3sukF90MZsVpU item in ienumerable_0)
		{
			icollection_0.Add(item);
		}
	}
}
