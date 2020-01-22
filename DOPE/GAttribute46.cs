using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class GAttribute46 : Attribute
{
	public GAttribute46(GEnum3 genum3_1)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.method_1(genum3_1);
	}

	[CompilerGenerated]
	public GEnum3 method_0()
	{
		return this.genum3_0;
	}

	[CompilerGenerated]
	private void method_1(GEnum3 genum3_1)
	{
		this.genum3_0 = genum3_1;
	}

	[CompilerGenerated]
	private GEnum3 genum3_0;
}
