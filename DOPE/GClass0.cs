using System;
using System.Collections.Generic;
using System.Linq;

public static class GClass0
{
	public static ICollection<cGWD5UZMgWApw2ey3e> smethod_0<cGWD5UZMgWApw2ey3e>(this ICollection<cGWD5UZMgWApw2ey3e> icollection_0, Func<cGWD5UZMgWApw2ey3e, bool> func_0)
	{
		foreach (cGWD5UZMgWApw2ey3e item in icollection_0.Where(func_0).ToList<cGWD5UZMgWApw2ey3e>())
		{
			icollection_0.Remove(item);
		}
		return icollection_0;
	}

	public static ICollection<ubPeJJWFnZUV8yQYQc> smethod_1<ubPeJJWFnZUV8yQYQc>(this ICollection<ubPeJJWFnZUV8yQYQc> icollection_0)
	{
		icollection_0.smethod_0(new Func<ubPeJJWFnZUV8yQYQc, bool>(GClass0.<>c__1<ubPeJJWFnZUV8yQYQc>.<>9.method_0));
		return icollection_0;
	}

	public static void smethod_2<zgDb7qn2X3mKxbtTbv>(this ICollection<zgDb7qn2X3mKxbtTbv> icollection_0, IEnumerable<zgDb7qn2X3mKxbtTbv> ienumerable_0)
	{
		foreach (zgDb7qn2X3mKxbtTbv item in ienumerable_0)
		{
			icollection_0.Add(item);
		}
	}
}
