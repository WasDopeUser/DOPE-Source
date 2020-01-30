using System;
using System.Collections.Generic;
using System.Linq;

public static class GClass0
{
	public static ICollection<kf5dKgw2pPBW9pltiR> smethod_0<kf5dKgw2pPBW9pltiR>(this ICollection<kf5dKgw2pPBW9pltiR> icollection_0, Func<kf5dKgw2pPBW9pltiR, bool> func_0)
	{
		foreach (kf5dKgw2pPBW9pltiR item in icollection_0.Where(func_0).ToList<kf5dKgw2pPBW9pltiR>())
		{
			icollection_0.Remove(item);
		}
		return icollection_0;
	}

	public static ICollection<Sa36m6qixGXDcNfYIH> smethod_1<Sa36m6qixGXDcNfYIH>(this ICollection<Sa36m6qixGXDcNfYIH> icollection_0)
	{
		icollection_0.smethod_0(new Func<Sa36m6qixGXDcNfYIH, bool>(GClass0.<>c__1<Sa36m6qixGXDcNfYIH>.<>9.method_0));
		return icollection_0;
	}

	public static void smethod_2<w9m933WohUcDXIxh53>(this ICollection<w9m933WohUcDXIxh53> icollection_0, IEnumerable<w9m933WohUcDXIxh53> ienumerable_0)
	{
		foreach (w9m933WohUcDXIxh53 item in ienumerable_0)
		{
			icollection_0.Add(item);
		}
	}
}
