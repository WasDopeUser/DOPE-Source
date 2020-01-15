using System;
using System.Collections.Generic;
using System.Linq;

public static class GClass0
{
	public static ICollection<us4pKVSKyTG1HNYTWV> smethod_0<us4pKVSKyTG1HNYTWV>(this ICollection<us4pKVSKyTG1HNYTWV> icollection_0, Func<us4pKVSKyTG1HNYTWV, bool> func_0)
	{
		foreach (us4pKVSKyTG1HNYTWV item in icollection_0.Where(func_0).ToList<us4pKVSKyTG1HNYTWV>())
		{
			icollection_0.Remove(item);
		}
		return icollection_0;
	}

	public static ICollection<b8I57qA6lIVuvMgZcH> smethod_1<b8I57qA6lIVuvMgZcH>(this ICollection<b8I57qA6lIVuvMgZcH> icollection_0)
	{
		icollection_0.smethod_0(new Func<b8I57qA6lIVuvMgZcH, bool>(GClass0.<>c__1<b8I57qA6lIVuvMgZcH>.<>9.method_0));
		return icollection_0;
	}

	public static void smethod_2<cL5RN3unx09sncKqtL>(this ICollection<cL5RN3unx09sncKqtL> icollection_0, IEnumerable<cL5RN3unx09sncKqtL> ienumerable_0)
	{
		foreach (cL5RN3unx09sncKqtL item in ienumerable_0)
		{
			icollection_0.Add(item);
		}
	}
}
