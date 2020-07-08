using System;
using System.Collections.Generic;
using System.Linq;

public static class GClass0
{
	public static ICollection<Bxb9Bg1y06bvqWLVKZ> KvnwsXdud<Bxb9Bg1y06bvqWLVKZ>(this ICollection<Bxb9Bg1y06bvqWLVKZ> icollection_0, Func<Bxb9Bg1y06bvqWLVKZ, bool> func_0)
	{
		foreach (Bxb9Bg1y06bvqWLVKZ item in icollection_0.Where(func_0).ToList<Bxb9Bg1y06bvqWLVKZ>())
		{
			icollection_0.Remove(item);
		}
		return icollection_0;
	}

	public static ICollection<Rye5evZOpQnaPbnKE2> smethod_0<Rye5evZOpQnaPbnKE2>(this ICollection<Rye5evZOpQnaPbnKE2> icollection_0)
	{
		icollection_0.KvnwsXdud(new Func<Rye5evZOpQnaPbnKE2, bool>(GClass0.<>c__1<Rye5evZOpQnaPbnKE2>.<>9.method_0));
		return icollection_0;
	}

	public static void smethod_1<bOXLZXoGwpCBsG8rqd>(this ICollection<bOXLZXoGwpCBsG8rqd> icollection_0, IEnumerable<bOXLZXoGwpCBsG8rqd> ienumerable_0)
	{
		foreach (bOXLZXoGwpCBsG8rqd item in ienumerable_0)
		{
			icollection_0.Add(item);
		}
	}
}
