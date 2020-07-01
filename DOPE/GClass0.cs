using System;
using System.Collections.Generic;
using System.Linq;

public static class GClass0
{
	public static ICollection<W4WCUtyOnak0UoBjDg> smethod_0<W4WCUtyOnak0UoBjDg>(this ICollection<W4WCUtyOnak0UoBjDg> icollection_0, Func<W4WCUtyOnak0UoBjDg, bool> func_0)
	{
		foreach (W4WCUtyOnak0UoBjDg item in icollection_0.Where(func_0).ToList<W4WCUtyOnak0UoBjDg>())
		{
			icollection_0.Remove(item);
		}
		return icollection_0;
	}

	public static ICollection<K0378s3hpKF8oTPXvG> smethod_1<K0378s3hpKF8oTPXvG>(this ICollection<K0378s3hpKF8oTPXvG> icollection_0)
	{
		icollection_0.smethod_0(new Func<K0378s3hpKF8oTPXvG, bool>(GClass0.<>c__1<K0378s3hpKF8oTPXvG>.<>9.method_0));
		return icollection_0;
	}

	public static void smethod_2<DTLQiBWbDSkirigRCC>(this ICollection<DTLQiBWbDSkirigRCC> icollection_0, IEnumerable<DTLQiBWbDSkirigRCC> ienumerable_0)
	{
		foreach (DTLQiBWbDSkirigRCC item in ienumerable_0)
		{
			icollection_0.Add(item);
		}
	}
}
