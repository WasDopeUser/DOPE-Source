using System;
using System.Collections.Generic;
using System.Linq;

public static class GClass0
{
	public static ICollection<RWJehG8BWCYfWkmwut> smethod_0<RWJehG8BWCYfWkmwut>(this ICollection<RWJehG8BWCYfWkmwut> icollection_0, Func<RWJehG8BWCYfWkmwut, bool> func_0)
	{
		foreach (RWJehG8BWCYfWkmwut item in icollection_0.Where(func_0).ToList<RWJehG8BWCYfWkmwut>())
		{
			icollection_0.Remove(item);
		}
		return icollection_0;
	}

	public static ICollection<Kvh2LSReIlsZ2sGtKP> smethod_1<Kvh2LSReIlsZ2sGtKP>(this ICollection<Kvh2LSReIlsZ2sGtKP> icollection_0)
	{
		icollection_0.smethod_0(new Func<Kvh2LSReIlsZ2sGtKP, bool>(GClass0.<>c__1<Kvh2LSReIlsZ2sGtKP>.<>9.MrxyPoKlD));
		return icollection_0;
	}

	public static void smethod_2<lguQYKLlPvDoTVjSyp>(this ICollection<lguQYKLlPvDoTVjSyp> icollection_0, IEnumerable<lguQYKLlPvDoTVjSyp> ienumerable_0)
	{
		foreach (lguQYKLlPvDoTVjSyp item in ienumerable_0)
		{
			icollection_0.Add(item);
		}
	}
}
